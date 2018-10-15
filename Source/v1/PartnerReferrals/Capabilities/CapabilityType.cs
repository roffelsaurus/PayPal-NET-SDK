using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public enum CapabilityType
    {
        [EnumMember]
        API_INTEGRATION,
        [EnumMember]
        BANK_ADDITION,
        [EnumMember]
        BILLING_AGREEMENT,
        [EnumMember]
        CONTEXTUAL_MARKETING_CONSENT
    }
}