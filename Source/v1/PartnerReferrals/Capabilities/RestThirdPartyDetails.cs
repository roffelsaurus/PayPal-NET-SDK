using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public class RestThirdPartyDetails
    {
        public RestThirdPartyDetails()
        {

        }

        [DataMember(Name = "partner_client_id", EmitDefaultValue = false)]
        public string PartnerClientId;

        [DataMember(Name = "feature_list", EmitDefaultValue = false)]
        public RestEndpointFeature[] RestEndpointFeatures;
    }
}