using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals
{
    [DataContract]
    public enum ProductName
    {
        [EnumMember]
        EXPRESS_CHECKOUT,
        [EnumMember]
        PPPLUS,
        [EnumMember]
        WP_PRO
    }
}
