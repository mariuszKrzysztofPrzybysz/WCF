namespace CategoryInformationClients.ServiceReferenceClient
{
    using System;
    using CategoryInformationServiceReference;

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (CategoryInformationServiceClient client = new CategoryInformationServiceClient("BasicHttpBinding_ICategoryInformationService"))
            {
                var responce = client.GetCategoryInformation(new CategoryInformationRequest
                {
                    CategoryId = 1
                });

                Console.WriteLine("Received responce");
                foreach (var category in responce.Categories)
                {
                    Console.WriteLine($"Id: {category.CategoryId}");
                    Console.WriteLine($"Name: {category.Name}");
                    Console.WriteLine($"Description: {category.Description}");
                    Console.WriteLine($"Photo: {category.Photo}");

                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}