using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.User
{
    [DataContract]
    public enum PartnerSpecificIdentifierType
    {
        [EnumMember]
        TRACKING_ID
    }
}