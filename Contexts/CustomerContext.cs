using ServiceProcess.Interfaces;

namespace ServiceProcess.Contexts
{
    public class CustomerContext : IServiceRequestContext
    {
        public int CustomerId { get; set; }
    }
}
