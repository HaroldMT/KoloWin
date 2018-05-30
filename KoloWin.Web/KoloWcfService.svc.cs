//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Data.Services.Providers;
using System.ServiceModel;
using System.Reflection;
using KoloWin.Poco;

namespace KoloWin.Web
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.PerCall,
         ConcurrencyMode = ConcurrencyMode.Multiple, AutomaticSessionShutdown = true)]
    public class KoloWcfService : EntityFrameworkDataService<KoloEntities>
    {
        private KoloEntities DataContext;

        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        protected override KoloEntities CreateDataSource()
        {
            DataContext = base.CreateDataSource();
            return DataContext;
        }

        protected override void HandleException(HandleExceptionArgs args)
        {
            // Handle exceptions raised in service operations.
            if (args.Exception is TargetInvocationException && args.Exception.InnerException != null)
            {
                var exception = args.Exception.InnerException as DataServiceException;
                args.Exception = exception ?? new DataServiceException(400, "" + args.Exception.InnerException.Message);
            }
            else
            {
                var msg = GetRealMessageFromException(args.Exception);
                args.Exception = new DataServiceException(400, msg);
            }
            base.HandleException(args);
        }

        private static string GetRealMessageFromException(Exception e)
        {
            var msg = "";
            if (e == null)
                return msg;
            msg = e.InnerException != null ? GetRealMessageFromException(e.InnerException) : e.Message;
            return msg;
        }
    }
}