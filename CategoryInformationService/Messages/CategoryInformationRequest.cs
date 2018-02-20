namespace CategoryInformationService.Messages
{
    using System.Runtime.Serialization;

    [DataContract]
    public class CategoryInformationRequest
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}