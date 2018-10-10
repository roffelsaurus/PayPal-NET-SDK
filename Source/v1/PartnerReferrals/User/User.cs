using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals.User
{
    [DataContract]
    public class User
    {
        public User()
        {

        }

        [DataMember(Name = "customer_type", EmitDefaultValue = false)]
        public CustomerType CustomerType;

        [DataMember(Name = "person_details", EmitDefaultValue = false)]
        public PersonDetails PersonDetails;

        


    }
}
