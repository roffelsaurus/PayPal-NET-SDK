using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public enum IntegrationType
    {
        [EnumMember]
        THIRD_PARTY
    }
}