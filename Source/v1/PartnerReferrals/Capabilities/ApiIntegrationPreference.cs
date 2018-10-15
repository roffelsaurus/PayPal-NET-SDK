using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public class ApiIntegrationPreference
    {
        public ApiIntegrationPreference()
        {

        }

        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId;

        [DataMember(Name = "rest_api_integration", EmitDefaultValue = false)]
        public RestApiIntegration RestApiIntegration;

        [DataMember(Name = "rest_third_party_details", EmitDefaultValue = false)]
        public RestThirdPartyDetails RestThirdPartyDetails;
        
    }
}