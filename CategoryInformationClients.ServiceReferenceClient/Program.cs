namespace CategoryInformationClients.ServiceReferenceClient
{
    using System;
    using CategoryInformationServiceReference;

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (CategoryInformationServiceClient client = new CategoryInformationServiceClient("WSHttpBinding_ICategoryInformationService"))
            {
                CategoryInformationResponse responce = null;
                try
                {
                    responce = client.GetCategoryInformation(new CategoryInformationRequest
                    {
                        CategoryId = 1
                    });

                    PrintResponce(responce);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Press [ENTER] to close client");
                Console.ReadLine();
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