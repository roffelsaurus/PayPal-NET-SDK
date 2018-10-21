//using System;
//using System.Collections.Generic;
//using System.Runtime.Serialization;
//using System.Text;

//namespace PayPal.v1.PartnerReferrals.User
//{
//    [DataContract]
//    public class PersonDetails
//    {
//        public PersonDetails()
//        {

//        }

//        [DataMember(Name = "email_address", EmitDefaultValue = false)]
//        public string EmailAddress;

//        [DataMember(Name = "name", EmitDefaultValue = false)]
//        public Name Name;

//        [DataMember(Name = "phone_contacts", EmitDefaultValue = false)]
//        public PhoneDetails[] PhoneContacts;

//        [DataMember(Name = "home_address", EmitDefaultValue = false)]
//        public Address HomeAddress;

//        [DataMember(Name = "nationality_country_code", EmitDefaultValue = false)]
//        public string NationalityCountryCode;

//        [DataMember(Name = "identity_documents", EmitDefaultValue = false)]
//        public IdentityDocument[] IdentityDocuments;
        
//        [DataMember(Name = "account_owner_relationships", EmitDefaultValue = false)]
//        public AccountOwnerRelationship[] AccountOwnerRelationships;
//    }
//}
