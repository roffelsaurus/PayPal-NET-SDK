using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public enum RestEndpointFeature
    {
        [EnumMember]
        PAYMENT,
        [EnumMember]
        REFUND,
        [EnumMember]
        PARTNER_FEE,
        [EnumMember]
        DELAY_FUNDS_DISBURSEMENT,
        [EnumMember]
        SWEEP_FUNDS_EXTERNAL_SINK,
        [EnumMember]
        READ_SELLER_DISPUTE,
        [EnumMember]
        UPDATE_SELLER_DISPUTE,
        [EnumMember]
        ADVANCED_TRANSACTIONS_SEARCH
    }
}