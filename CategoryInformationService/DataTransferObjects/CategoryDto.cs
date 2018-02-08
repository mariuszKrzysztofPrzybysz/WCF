namespace CategoryInformationService.DataTransferObjects
{
    using System.Runtime.Serialization;

    [DataContract(Name = "Category", Namespace = "CategoryInformationService.Types")]
    internal class CategoryDto
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember(Name = "Photo")]
        public string PhotoBase64 { get; set; }
    }
}