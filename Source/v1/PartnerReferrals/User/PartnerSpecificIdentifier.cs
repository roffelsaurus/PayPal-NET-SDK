using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.User
{
    [DataContract]
    public class PartnerSpecificIdentifier
    {

        public PartnerSpecificIdentifier()
        {

        }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string PartnerSpecificIdentifierType;

        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value;
    }
}