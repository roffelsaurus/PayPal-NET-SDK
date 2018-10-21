using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals.User
{
    /// <summary>
    /// 
    /// Subset of customer_data needed for Partner Referrals
    /// https://developer.paypal.com/docs/api/partner-referrals/v1/#definition-user
    /// </summary>
    [DataContract]
    public class User
    {
        public User()
        {

        }

        //[DataMember(Name = "customer_type", EmitDefaultValue = false)]
        //public CustomerType CustomerType;

        //[DataMember(Name = "person_details", EmitDefaultValue = false)]
        //public PersonDetails PersonDetails;


        [DataMember(Name = "partner_specific_identifiers", EmitDefaultValue = false)]
        public PartnerSpecificIdentifier[] PartnerSpecificIdentifiers;
    }
}
