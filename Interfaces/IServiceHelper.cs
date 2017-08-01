using ServiceProcess.TransferObjects;

namespace ServiceProcess.Interfaces
{
    public interface IServiceHelper
    {
        BaseTransferObject Execute(IServiceRequestContext context);
    }
}
