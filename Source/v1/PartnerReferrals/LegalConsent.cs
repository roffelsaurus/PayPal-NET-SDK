using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals
{
    [DataContract]
    public class LegalConsent
    {
        public LegalConsent()
        {

        }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public LegalConsentType Type;

        [DataMember(Name = "granted", EmitDefaultValue = false)]
        public bool Granted;
    }
}
