using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.Capabilities
{
    [DataContract]
    public class RestApiIntegration
    {
        public RestApiIntegration()
        {
        }

        [DataMember(Name = "integration_method", EmitDefaultValue = false)]
        public string IntegrationMethod;



        [DataMember(Name = "integration_type", EmitDefaultValue = false)]
        public string IntegrationType;
    }
}