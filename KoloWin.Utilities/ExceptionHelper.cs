using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Services;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace KoloWin.Utilities
{
    public static class ExceptionHelper
    {
        public static string ValidationErrorsToText(ICollection<DbValidationError> errors)
        {
            var sb = new StringBuilder();

            foreach (var validationError in errors)
            {
                sb.AppendFormat("Property: {0}\tError: {1}\n", validationError.PropertyName,
                    HtmlHelper.GetText(validationError.ErrorMessage));
            }
            sb.AppendLine("\n");
            var msg = sb.ToString();
            return msg;
        }

        public static string GetMessageFromException(Exception e)
        {
            var msg = "";
            if (e == null) return msg;
            var type = e.GetType();
            if (type == typeof(DbEntityValidationException))
            {
                var dbEx = e as DbEntityValidationException;
                var sb = new StringBuilder();
                sb.AppendLine("EntityValidationError : ");
                if (dbEx != null)
                {
                    sb.AppendLine(
                        ValidationErrorsToText(
                            dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors)
                                .ToList()));
                    sb.AppendLine($"Message : {HtmlHelper.GetText(dbEx.Message)}");
                }
                msg = sb.ToString();
            }
            else if (type == typeof(DataServiceRequestException))
            {
                var dsEx = e as DataServiceRequestException;
                if (dsEx == null) return msg;
                msg = $"QueryError : {dsEx.Message}";
                if (dsEx.InnerException != null) msg += GetMessageFromException(dsEx.InnerException);
            }
            else if (type == typeof(DataServiceException))
            {
                var dsEx = e as DataServiceException;
                if (dsEx == null) return msg;
                msg = $"DataError : {dsEx.Message}";
                if (dsEx.InnerException != null) msg += GetMessageFromException(dsEx.InnerException);
            }
            else if (e.InnerException != null)
            {
                msg = GetMessageFromException(e.InnerException);
            }
            else
            {
                //msg = $"Exception Type : {type.Name}\n" +
                //      $" From: {e.TargetSite?.Name}\n" +
                //      $" Message: {HtmlHelper.GetText(e.Message)}\n";

                msg = $"Message: {HtmlHelper.GetText(e.Message)}\t";
                //+ $"Exception Type : {type.Name}\t" +
                //$"From: {e.TargetSite?.Name}\n";
            }
            return msg;
        }

        public static string GetDetailedMessageFromException(Exception e)
        {
            var msg = "";
            if (e == null) return msg;
            var type = e.GetType();
            if (type == typeof(DbEntityValidationException))
            {
                var dbEx = e as DbEntityValidationException;
                var sb = new StringBuilder();
                sb.AppendLine("EntityValidationError : ");
                if (dbEx != null)
                {
                    sb.AppendLine(
                        ValidationErrorsToText(
                            dbEx.EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors)
                                .ToList()));
                    sb.AppendLine($"Message : {HtmlHelper.GetText(dbEx.Message)}");
                }
                msg = sb.ToString();
            }
            else if (type == typeof(DataServiceRequestException))
            {
                var dsEx = e as DataServiceRequestException;
                if (dsEx == null) return msg;
                msg = $"QueryError : {dsEx.Message}";
                if (dsEx.InnerException != null) msg += GetDetailedMessageFromException(dsEx.InnerException);
            }
            else if (type == typeof(DataServiceException))
            {
                var dsEx = e as DataServiceException;
                if (dsEx == null) return msg;
                msg = $"DataError : {dsEx.Message}";
                if (dsEx.InnerException != null) msg += GetDetailedMessageFromException(dsEx.InnerException);
            }
            else if (e.InnerException != null)
            {
                msg = GetDetailedMessageFromException(e.InnerException);
            }
            else
            {
                msg = $"Exception Type : {type.Name}\n" +
                      $" From: {e.TargetSite?.Name}\n" +
                      $" Message: {HtmlHelper.GetText(e.Message)}\n" +
                      $" Stack: {e.StackTrace}";

                //msg = $"Message: {HtmlHelper.GetText(e.Message)}\t";
                //+ $"Exception Type : {type.Name}\t" +
                //$"From: {e.TargetSite?.Name}\n";
            }
            return msg;
        }

        private static string ExtractExceptionMesssage(string exceptionMessage)
        {
            try
            {
                var doc = XElement.Parse(exceptionMessage);
                var result = string.Join("\n", doc.Descendants("message").Select(m => m.Value));
                return result;
            }
            catch
            {
                return exceptionMessage;
            }
        }
    }
}