namespace CategoryInformationClients.ChannelFactoryClient
{
    using CategoryInformationService.ServiceContracts;
    using CategoryInformationService.Messages;
    using System;
    using System.ServiceModel;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var baseAddr = new Uri("http://localhost:81/PersonalInformationService.svc/");
            /*
             1. http://localhost:81/PersonalInformationService.svc ENTER - adres wzięty z IIS'a, który wcześniej zarejestrowaliśmy
             2. http://hpmprzybysz:81/PersonalInformationService.svc?wsdl ENTER
             3. <wsdl:binding name="BasicHttpBinding...

            lub

            _App.config ->  <endpoint address="" binding="basicHttpBinding" ...
             */
            using (ChannelFactory<ICategoryInformationService> factory
                = new ChannelFactory<ICategoryInformationService>(new BasicHttpBinding(), new EndpointAddress(baseAddr)))
            {
                ICategoryInformationService proxy = factory.CreateChannel();

                var responce = proxy.GetCategoryInformation(new CategoryInformationRequest
                {
                    CategoryId = 2
                });

                if (responce == null)
                    return;

                foreach (var category in responce.Categories)
                {
                    Console.WriteLine($"Id: {category.CategoryId}");
                    Console.WriteLine($"Name: {category.Name}");
                    Console.WriteLine($"Description: {category.Description}");
                    Console.WriteLine($"Photo: {category.PhotoBase64}");

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}