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
        public PartnerSpecificIdentifierType Type;

        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value;
    }
}