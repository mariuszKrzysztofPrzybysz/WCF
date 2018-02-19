namespace CategoryInformationClients.ServiceReferenceClientAsync
{
    using System;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using CategoryInformationClients.ServiceReferenceClientAsync.CategoryInformationServiceReference;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Press [ENTER] to call CategoryInformationService");
            Console.ReadKey();

            using (CategoryInformationServiceClient client = new CategoryInformationServiceClient("WSHttpBinding_ICategoryInformationService"))
            {
                client.GetCategoryInformationCompleted
                    += new EventHandler<GetCategoryInformationCompletedEventArgs>(client_GetCategoryInformationCompleted);
                var objSync = new Object();
                client.GetCategoryInformationAsync(new CategoryInformationRequest
                {
                    CategoryId = 1
                });

                Console.WriteLine("Press [ENTER] to close client");
                Console.ReadKey();
            }
        }

        private static void client_GetCategoryInformationCompleted(object sender, GetCategoryInformationCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                PrintResponce(e.Result);
            }
            else
            {
                Console.WriteLine("Async request exception");
                Console.WriteLine(e.Error.Message);
            }
        }

        private static void PrintResponce(CategoryInformationResponse responce)
        {
            Console.WriteLine("Received responce");
            foreach (var category in responce.Categories)
            {
                Console.WriteLine($"Id: {category.CategoryId}");
                Console.WriteLine($"Name: {category.Name}");
                Console.WriteLine($"Description: {category.Description}");
                Console.WriteLine($"Photo: {category.Photo}");

                Console.WriteLine();
            }
        }
    }
}