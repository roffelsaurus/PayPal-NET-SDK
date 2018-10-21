using PayPal.v1.PartnerReferrals.Capabilities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using UserNS = PayPal.v1.PartnerReferrals.User;

namespace PayPal.v1.PartnerReferrals
{
    [DataContract]
    public class PartnerReferral
    {
        public PartnerReferral()
        {

        }


        [DataMember(Name = "customer_data", EmitDefaultValue = false)]
        public UserNS.User CustomerData;

        [DataMember(Name = "requested_capabilities", EmitDefaultValue = false)]
        public Capability[] RequestedCapabilities;

        [DataMember(Name = "web_experience_preference", EmitDefaultValue = false)]
        public WebExperiencePreference WebExperiencePreference;

        [DataMember(Name = "collected_consents", EmitDefaultValue = false)]
        public LegalConsent[] CollectedConsents;

        [DataMember(Name = "products", EmitDefaultValue = false)]
        public string[] Products;
    }
}
