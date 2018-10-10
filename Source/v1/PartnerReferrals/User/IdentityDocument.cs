using System.Runtime.Serialization;

namespace PayPal.v1.PartnerReferrals.User
{
    [DataContract]
    public class IdentityDocument
    {
        public IdentityDocument()
        {

        }
    }

    [DataContract(Name = "type")]
    public enum IdentityType
    {
        [EnumMember]
        SOCIAL_SECURITY_NUMBER,
        [EnumMember]
        EMPLOYMENT_IDENTIFICATION_NUMBER,
        [EnumMember]
        TAX_IDENTIFICATION_NUMBER,
        [EnumMember]
        PASSPORT_NUMBER,
        [EnumMember]
        PENSION_FUND_ID,
        [EnumMember]
        MEDICAL_INSURANCE_ID,
        [EnumMember]
        CNPJ,
        [EnumMember]
        CPF,
        [EnumMember]
        PAN
    }
}