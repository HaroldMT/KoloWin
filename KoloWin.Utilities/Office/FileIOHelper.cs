using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KoloWin.Utilities.Office
{
    public static class FileIoHelper
    {
        private static object _fileLock = new object();

        public static string[][] ReadCsvFileAllDataLine(string fullPath, char separator, string strToRemove, string strToRemove1, out string strError)
        {
            strError = "";
            string[][] myData = null;
            try
            {
                lock (_fileLock)
                {
                    if (File.Exists(fullPath))
                    {
                        var allLines = File.ReadAllLines(fullPath);
                        if (allLines.Length >= 1)
                        {
                            myData = new string[allLines.Length][];
                            for (var i = 0; i < allLines.Length; i++)
                            {
                                var tmpStr = allLines[i].Replace(strToRemove, "").Replace(strToRemove1, "");
                                if (string.IsNullOrEmpty(tmpStr))
                                {
                                    strError = "Aucune donnée dans la ligne";
                                    continue;
                                }
                                myData[i] = tmpStr.Split(separator);
                            }
                        }
                        else
                        {
                            strError = "Aucune ligne de données trouvée";
                        }
                    }
                    else
                    {
                        strError = "Aucun fichier trouvé";
                    }
                }
            }
            catch (Exception ex)
            {
                strError = ExceptionHelper.GetMessageFromException(ex);
            }
            return myData;
        }

        public static string[] ReadCsvFileFirstDataLine(string fullPath, char separator, string strToRemove, string strToRemove1, out string strError)
        {
            strError = "";
            string[] data = null;
            try
            {
                lock (_fileLock)
                {
                    if (File.Exists(fullPath))
                    {
                        var allLines = File.ReadAllLines(fullPath);
                        var firstLine = allLines.FirstOrDefault();
                        if (firstLine != null)
                        {
                            var dataLine = firstLine.Replace(strToRemove, "").Replace(strToRemove1, "");
                            data = dataLine.Split(separator);
                            if (data.Length == 0)
                            {
                                strError = "Aucune champ trouvé";
                            }
                        }
                        else
                        {
                            strError = "Aucune donnée trouvée";
                        }
                    }
                    else
                    {
                        strError = "Aucun fichier trouvé";
                    }
                }
            }
            catch (Exception ex)
            {
                strError = ExceptionHelper.GetMessageFromException(ex);
            }
            return data;
        }

        public static string ReadFromTextFile(string fullPath, out string strError)
        {
            strError = "";
            string text = null;
            try
            {
                lock (_fileLock)
                {
                    if (File.Exists(fullPath))
                    {
                        using (var fs = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Read))
                        {
                            using (var reader = new StreamReader(fs))
                            {
                                text = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
            return text;
        }

        public static string ToCsv<T>(this IEnumerable<T> items)
                                            where T : class
        {
            var csvBuilder = new StringBuilder();
            var properties = typeof(T).GetProperties();
            foreach (T item in items)
            {
                string line = string.Join(",", properties.Select(p => p.GetValue(item, null).ToCsvValue()).ToArray());
                csvBuilder.AppendLine(line);
            }
            return csvBuilder.ToString();
        }

        public static void WriteToTextFile(string fullPath, string text, out string strError,
            FileMode fileMode = FileMode.Create)
        {
            try
            {
                lock (_fileLock)
                {
                    strError = "";
                    if (fileMode == FileMode.Create)
                    {
                        if (File.Exists(fullPath)) File.Delete(fullPath);
                        File.WriteAllText(fullPath, text);
                    }
                    else
                        using (var fs = new FileStream(fullPath, fileMode))
                        {
                            using (var writer = new StreamWriter(fs))
                            {
                                writer.Write(text);
                            }
                        }
                }
            }
            catch (Exception e)
            {
                strError = ExceptionHelper.GetMessageFromException(e);
                //ElLogger.LogError(strError);
            }
        }

        private static string ToCsvValue<T>(this T item)
        {
            if (item == null) return "\"\"";

            if (item is string)
            {
                return string.Format("\"{0}\"", item.ToString().Replace("\"", "\\\""));
            }
            double dummy;
            if (double.TryParse(item.ToString(), out dummy))
            {
                return string.Format("{0}", item);
            }
            return string.Format("\"{0}\"", item);
        }
    }
}