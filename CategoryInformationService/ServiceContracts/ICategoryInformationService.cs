namespace CategoryInformationService.ServiceContracts
{
    using System.ServiceModel;
    using CategoryInformationService.Messages;

    [ServiceContract]
    internal interface ICategoryInformationService
    {
        [OperationContract]
        CategoryInformationResponse GetCategoryInformation(CategoryInformationRequest request);
    }
}