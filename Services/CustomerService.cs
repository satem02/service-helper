using ServiceProcess.ServiceHelpers;
using ServiceProcess.Contexts;
using ServiceProcess.TransferObjects;
using ServiceProcess.Interfaces;

namespace ServiceProcess.Services
{
    public class CustomerController : ServiceHelper
    {
        public override BaseTransferObject Execute(IServiceRequestContext context)
        {
            var result = new BaseTransferObject();
            
            var requestContext = context as CustomerContext;
            int customerId = requestContext.CustomerId;

            return result;
        }
    }
}
