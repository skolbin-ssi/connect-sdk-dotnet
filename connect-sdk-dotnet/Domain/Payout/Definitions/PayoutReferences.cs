/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class PayoutReferences
    {
        /// <summary>
        /// Your invoice number (on printed invoice) that is also returned in our report files
        /// </summary>
        public string InvoiceNumber { get; set; } = null;

        /// <summary>
        /// Order Identifier generated by the merchant
        /// <br />Note: This does not need to have a unique value for each transaction
        /// </summary>
        public long? MerchantOrderId { get; set; } = null;

        /// <summary>
        /// <div class="alert alert-info">Note that the maximum length of this field for transactions processed on the GlobalCollect platform is 30.</div>Your unique reference of the transaction that is also returned in our report files. This is almost always used for your reconciliation of our report files.
        /// </summary>
        public string MerchantReference { get; set; } = null;
    }
}
