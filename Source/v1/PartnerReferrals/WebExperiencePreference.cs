using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1.PartnerReferrals
{
    [DataContract]
    public class WebExperiencePreference
    {
        public WebExperiencePreference()
        {

        }

        /// <summary>
        /// The partner logo URL to display in the seller onboarding flow.
        /// </summary>
        [DataMember(Name = "partner_logo_url", EmitDefaultValue = false)]
        public string PartnerLogoUrl;

        /// <summary>
        /// The description of the return URL.
        /// </summary>
        [DataMember(Name = "return_url_description", EmitDefaultValue = false)]
        public string ReturnUrlDescription;

        /// <summary>
        /// If renew_action_url expires, redirect the customer to this URL.
        /// </summary>
        [DataMember(Name = "action_renewal_url", EmitDefaultValue = false)]
        public string ActionRenewalUrl;

        /// <summary>
        /// Indicates whether to show an add credit card page.
        /// </summary>
        [DataMember(Name = "show_add_credit_card", EmitDefaultValue = false)]
        public bool ShowAddCreditCard;

        /// <summary>
        /// Indicates whether to ask the customer to initiate 
        /// confirmation of their mobile phone (the phone that the partner designated as MOBILE in the customer data). 
        /// Default isfalse.
        /// </summary>
        [DataMember(Name = "show_mobile_confirm", EmitDefaultValue = false)]
        public bool ShowMobileConfirm;

        /// <summary>
        /// Indicates whether to provide a single page signup flow in a mini browser.Default is to provide a full-size, multi-page flow.
        /// </summary>
        [DataMember(Name = "use_mini_browser", EmitDefaultValue = false)]
        public bool UseMiniBrowser;

        /// <summary>
        /// Indicates whether to use the hosted_user_agreement_url to 
        /// confirm the customer's email address. 
        /// If true, PayPal appends the email confirmation code to 
        /// hosted_user_agreement_url, and when a customer successfully 
        /// accesses the hosted user agreement URL, confirms the customer's 
        /// email address.If false, PayPal does not append the 
        /// confirmation code to the URL and does not confirm the email address.
        /// </summary>
        [DataMember(Name = "use_hua_email_confirmation", EmitDefaultValue = false)]
        public bool UseHuaEmailConfirmation;
    }
}
