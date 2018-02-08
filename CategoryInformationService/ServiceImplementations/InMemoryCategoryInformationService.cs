namespace CategoryInformationService.ServiceImplementations
{
    using System.Collections.Generic;
    using System.Linq;
    using CategoryInformationService.DataTransferObjects;
    using CategoryInformationService.Messages;
    using CategoryInformationService.ServiceContracts;

    public class InMemoryCategoryInformationService : ICategoryInformationService
    {
        private IEnumerable<CategoryDto> _inMemory()
        {
            return new List<CategoryDto>
            {
                new CategoryDto
                {
                    CategoryId=1,
                    Name="A",
                    Description="A description",
                    PhotoBase64=string.Empty
                },
                new CategoryDto
                {
                    CategoryId=2,
                    Name="B",
                    Description="B description",
                    PhotoBase64=string.Empty
                },
                new CategoryDto
                {
                    CategoryId=3,
                    Name="C",
                    Description="C description",
                    PhotoBase64=string.Empty
                },
                new CategoryDto
                {
                    CategoryId=4,
                    Name="D",
                    Description="D description",
                    PhotoBase64=string.Empty
                }
            };
        }

        public CategoryInformationResponse GetCategoryInformation(CategoryInformationRequest request)
        {
            var categoryDto = _inMemory().SingleOrDefault(c => c.CategoryId == request.CategoryId);
            var response = new CategoryInformationResponse
            {
                Categories = new List<CategoryDto>()
            };
            response.Categories.Add(categoryDto);

            return response;
        }
    }
}