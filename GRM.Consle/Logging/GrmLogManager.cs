using Microsoft.Build.Utilities;
using NLog;
using System;

namespace GRM.Consle.Logging
{
    public static class GrmLogManager

    {
        private static readonly NLog.Logger Logger = LogManager.GetCurrentClassLogger();

        public static void LogErrors(Exception ex)
        {
            Logger.Debug(ex.Message);
            Logger.Debug(ex.StackTrace);
            Logger.Debug(ex.InnerException);
        }
    }
}