namespace CategoryInformationHosts.SelfHost
{
    using System;
    using System.ServiceModel;
    using CategoryInformationService.ServiceImplementations;

    public class Program
    {
        private static void Main(string[] args) => RunHost();

        private static void RunHost()
        {
            using (var host = new ServiceHost(typeof(InMemoryCategoryInformationService)))
            {
                Console.WriteLine("Category Information Service host starting...");
                host.Open();
                Console.WriteLine("Press [ENTER] to stop service");
                Console.ReadKey(false);
            }
        }
    }
}