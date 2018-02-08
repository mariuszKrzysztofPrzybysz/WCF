namespace CategoryInformationService.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using CategoryInformationService.DataTransferObjects;

    [DataContract]
    public class CategoryInformationResponse
    {
        [DataMember]
        public List<CategoryDto> Categories { get; set; }
    }
}