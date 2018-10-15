using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public enum IntegrationMethod
    {
        [EnumMember]
        PAYPAL,
        [EnumMember]
        BRAINTREE
    }
}