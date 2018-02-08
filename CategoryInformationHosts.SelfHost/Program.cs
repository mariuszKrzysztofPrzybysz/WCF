namespace CategoryInformationHosts.SelfHost
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using CategoryInformationService.ServiceContracts;
    using CategoryInformationService.ServiceImplementations;

    public class Program
    {
        private static void Main(string[] args) => RunInlineConfiguredHost();

        private static void RunHost()
        {
            using (var host = new ServiceHost(typeof(InMemoryCategoryInformationService)))
            {
                Console.WriteLine("Category Information Service host starting...");
                //Run host
                host.Open();
                Console.WriteLine("Press [ENTER] to stop service");
                Console.ReadKey(false);
            }
        }

        private static void RunInlineConfiguredHost()
        {
            var baseAddr = new Uri("http://localhost:8733/Design_Time_Addresses/CategoryInformationService/InMemoryCategoryInformationService/");
            using (var host = new ServiceHost(typeof(InMemoryCategoryInformationService), baseAddr))
            {
                //Add endpoint
                host.AddServiceEndpoint(typeof(ICategoryInformationService)
                    , new BasicHttpBinding()
                    , baseAddr);

                //Enable MEX
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                host.AddServiceEndpoint(new ServiceMetadataEndpoint(new EndpointAddress($"{baseAddr.AbsoluteUri}mex")));

                Console.WriteLine("Category Information Service host starting...");
                //Run host
                host.Open();
                Console.WriteLine("Press [ENTER] to stop service");
                Console.ReadKey(false);
            }
        }
    }
}