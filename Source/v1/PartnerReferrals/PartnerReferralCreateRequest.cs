using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.v1.PartnerReferrals
{
    public class PartnerReferralCreateRequest : HttpRequest
    {

        public PartnerReferralCreateRequest() : base("/v1/customer/partner-referrals", HttpMethod.Post, typeof(PartnerReferralCreateRequest))
        {

        }
    }
}
