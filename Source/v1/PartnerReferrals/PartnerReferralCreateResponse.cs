using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals
{
    [DataContract]
    public class PartnerReferralCreateResponse
    {
        public PartnerReferralCreateResponse()
        {

        }

        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;
    }
}
