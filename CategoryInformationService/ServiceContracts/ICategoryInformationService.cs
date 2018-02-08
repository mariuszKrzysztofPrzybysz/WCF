namespace CategoryInformationService.ServiceContracts
{
    using System.ServiceModel;
    using CategoryInformationService.Messages;

    [ServiceContract]
    public interface ICategoryInformationService
    {
        [OperationContract]
        CategoryInformationResponse GetCategoryInformation(CategoryInformationRequest request);
    }
}