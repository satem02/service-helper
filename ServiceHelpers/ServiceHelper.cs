using ServiceProcess.TransferObjects;
using ServiceProcess.Interfaces;
using ServiceProcess.Log;

namespace ServiceProcess.ServiceHelpers
{
    public abstract class ServiceHelper : IServiceHelper
    {
        private static readonly BaseLogger _logger = new BaseLogger();

        public abstract BaseTransferObject Execute(IServiceRequestContext context);

        protected BaseLogger Logger
        {
            get { return _logger; }
        }
    }
}
