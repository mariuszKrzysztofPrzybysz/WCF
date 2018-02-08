namespace CategoryInformationService.Messages
{
    using System.Runtime.Serialization;

    [DataContract]
    internal class CategoryInformationRequest
    {
        [DataMember]
        public int CategoryId { get; set; }
    }
}