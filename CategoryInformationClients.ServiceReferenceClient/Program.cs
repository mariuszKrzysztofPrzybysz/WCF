namespace CategoryInformationClients.ServiceReferenceClient
{
    using System;
    using CategoryInformationServiceReference;

    internal class Program
    {
        private static void Main(string[] args) => CallWithLargeMessage();

        private static void CallWithLargeMessage()
        {
            using (CategoryInformationServiceClient
                client = new CategoryInformationServiceClient("WSHttpBinding_ICategoryInformationService"))
            {
                try
                {
                    var description = new System.Text.StringBuilder();
                    for (int i = 0; i < 819; i++)
                        description.Append("0123456789");
                    description.Append("123");

                    var response = client.GetCategoryInformation(new CategoryInformationRequest
                    {
                        CategoryId = 1,
                        Description = description.ToString()
                    });

                    PrintResponse(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                Console.ReadLine();
            }
        }

        private static void PrintResponse(CategoryInformationResponse responce)
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