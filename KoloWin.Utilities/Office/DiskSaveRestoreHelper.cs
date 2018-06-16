using System;
using System.Collections.Generic;
using System.IO;

namespace KoloWin.Utilities.Office
{
    public static class DiskSaveRestoreHelper
    {
        public enum StoreType
        {
            Config = 0,
            Log,
            Operation,
            Derogation,
            Other
        }

        private const string FileExtension = ".txt";
        private static readonly string ConfigPath;
        private static readonly string LogPath;
        private static readonly string OperationPath;
        private static readonly string DerogationPath;
        private static readonly string OtherPath;
        private static readonly string OldConfigPath;
        private static readonly string OldLogPath;
        private static readonly string OldOperationPath;
        private static readonly string OldOtherPath;

        static DiskSaveRestoreHelper()
        {
            var rootFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var oldRootFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ConfigPath = Path.Combine(rootFolder, "Gravity", "Config");
            LogPath = Path.Combine(rootFolder, "Gravity", "Log");
            OperationPath = Path.Combine(rootFolder, "Gravity", "Operation");
            DerogationPath = Path.Combine(rootFolder, "Gravity", "Derogation");
            OtherPath = Path.Combine(rootFolder, "Gravity", "Other");
            OldConfigPath = Path.Combine(oldRootFolder, "Gravity", "Config");
            OldLogPath = Path.Combine(oldRootFolder, "Gravity", "Log");
            OldOperationPath = Path.Combine(oldRootFolder, "Gravity", "Operation");
            OldOtherPath = Path.Combine(oldRootFolder, "Gravity", "Other");
            Directory.CreateDirectory(ConfigPath);
            Directory.CreateDirectory(LogPath);
            Directory.CreateDirectory(OperationPath);
            Directory.CreateDirectory(DerogationPath);
            Directory.CreateDirectory(OtherPath);
        }

        public static string GetFolderPath(StoreType store)
        {
            var path = "";
            switch (store)
            {
                case StoreType.Config:
                    path = ConfigPath;
                    break;

                case StoreType.Log:
                    path = LogPath;
                    break;

                case StoreType.Operation:
                    path = OperationPath;
                    break;

                case StoreType.Derogation:
                    path = DerogationPath;
                    break;

                case StoreType.Other:
                    break;

                default:
                    path = OtherPath;
                    break;
            }
            return path;
        }

        public static string OldGetFolderPath(StoreType store)
        {
            string path;
            switch (store)
            {
                case StoreType.Config:
                    path = OldConfigPath;
                    break;

                case StoreType.Log:
                    path = OldLogPath;
                    break;

                case StoreType.Operation:
                    path = OldOperationPath;
                    break;

                default:
                    path = OldOtherPath;
                    break;
            }
            return path;
        }

        public static void WriteToStore<T>(T entity, string fileName, StoreType store, out string strError)
        {
            try
            {
                fileName += FileExtension;
                var fullPath = Path.Combine(GetFolderPath(store), fileName);
                var data = SerializationHelper.SerializeToJson(entity);
                FileIoHelper.WriteToTextFile(fullPath, data, out strError);
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
        }

        public static void WriteListToStore<T>(List<T> entities, string fileName, StoreType store, out string strError)
        {
            try
            {
                fileName += FileExtension;
                var fullPath = Path.Combine(GetFolderPath(store), fileName);
                var data = SerializationHelper.SerializeToJson(entities);
                FileIoHelper.WriteToTextFile(fullPath, data, out strError);
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
        }

        public static T ReadFromStore<T>(string fileName, StoreType store, out string strError)
        {
            var entity = default(T);
            try
            {
                fileName += FileExtension;
                var fullPath = Path.Combine(GetFolderPath(store), fileName);
                var data = FileIoHelper.ReadFromTextFile(fullPath, out strError);
                if (!string.IsNullOrEmpty(data))
                {
                    entity = SerializationHelper.DeserializeFromJsonString<T>(data);
                }
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
            return entity;
        }

        public static List<T> ReadListFromStore<T>(string fileName, StoreType store, out string strError)
        {
            List<T> entities = null;
            try
            {
                fileName += FileExtension;
                var fullPath = Path.Combine(GetFolderPath(store), fileName);
                if (File.Exists(fullPath))
                {
                    var data = FileIoHelper.ReadFromTextFile(fullPath, out strError);
                    entities = SerializationHelper.DeserializeFromJsonString<List<T>>(data);
                }
                else
                {
                    strError = "Le fichier spécifié n'existe pas";
                }
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
            return entities ?? new List<T>();
        }

        public static void AddItemToStore<T>(T entity, string filename, StoreType store, out string strError)
        {
            var entityList = ReadListFromStore<T>(filename, store, out strError);
            if (strError != "") return;
            entityList.Add(entity);
            WriteListToStore(entityList, filename, store, out strError);
        }

        public static List<T> RemoveItemFromStore<T>(T entity, string filename, StoreType store, out string strError)
        {
            var entityList = ReadListFromStore<T>(filename, store, out strError);
            //if (strError != "") return;
            if (entityList.Remove(entity))
                WriteListToStore(entityList, filename, store, out strError);
            else
            {
                strError = "Aucune donnée trouvée";
            }
            return entityList;
        }
    }
}