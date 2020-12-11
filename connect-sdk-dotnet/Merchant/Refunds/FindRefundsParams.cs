/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Refunds
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/find.html">Find refunds</a>
    /// </summary>
    public class FindRefundsParams : AbstractParamRequest
    {
        /// <summary>
        /// Your hosted checkout identifier to filter on.
        /// </summary>
        public string HostedCheckoutId { get; set; } = null;

        /// <summary>
        /// Your unique transaction reference to filter on.
        /// </summary>
        public string MerchantReference { get; set; } = null;

        /// <summary>
        /// Your order identifier to filter on.
        /// </summary>
        public long? MerchantOrderId { get; set; } = null;

        /// <summary>
        /// The zero-based index of the first refund in the result. If omitted, the offset will be 0.
        /// </summary>
        public int? Offset { get; set; } = null;

        /// <summary>
        /// The maximum number of refunds to return, with a maximum of 100. If omitted, the limit will be 10.
        /// </summary>
        public int? Limit { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (HostedCheckoutId != null)
            {
                result.Add(new RequestParam("hostedCheckoutId", HostedCheckoutId));
            }
            if (MerchantReference != null)
            {
                result.Add(new RequestParam("merchantReference", MerchantReference));
            }
            if (MerchantOrderId != null)
            {
                result.Add(new RequestParam("merchantOrderId", MerchantOrderId.ToString()));
            }
            if (Offset != null)
            {
                result.Add(new RequestParam("offset", Offset.ToString()));
            }
            if (Limit != null)
            {
                result.Add(new RequestParam("limit", Limit.ToString()));
            }
            return result;
        }
    }
}
