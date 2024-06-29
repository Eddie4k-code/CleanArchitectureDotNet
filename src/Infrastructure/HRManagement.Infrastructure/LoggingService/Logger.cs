using HR.LeaveManagement.Application.Contracts.Logging;
using Microsoft.Extensions.Logging;

namespace HRManagement.Infrastructure.LoggingService {


    public class Logger<T> : IAppLogger<T>
    {


        private readonly ILogger<T> _logger;

        

        public Logger(ILoggerFactory loggerFactory) {

            this._logger = loggerFactory.CreateLogger<T>();

        }

        public void LogInformation(string message, params object[] args)
        {
            System.Console.WriteLine(message);
        }

        public void LogWarning(string message, params object[] args)
        {
            System.Console.WriteLine(message);
        }
    }


}