using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public class Capability
    {
        public Capability()
        {

        }

        [DataMember(Name = "capability", EmitDefaultValue = false)]
        public CapabilityType CapabilityType;

        [DataMember(Name = "api_integration_preference", EmitDefaultValue = false)]
        public ApiIntegrationPreference ApiIntegrationPreference;
    }
}
