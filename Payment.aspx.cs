using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using CCA.Util;

namespace CCAvenue
{
    public partial class Payment : System.Web.UI.Page
    {
        CCACrypto ccaCrypto = new CCACrypto();
        string workingKey = "1AE191DB022EB82EBD136F5F29AE0B35";//put in the 32bit alpha numeric key in the quotes provided here 	
        string ccaRequest = "";
        public string strEncRequest = "";
        public string strAccessCode = "AVEH20KJ31AY17HEYA";// put the access key in the quotes provided here.
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            ccaRequest = ccaRequest + tid.ID + "=" + 2124*r.Next() + "&";
            ccaRequest = ccaRequest + merchant_id.ID + "=" + merchant_id.Value + "&";
            ccaRequest = ccaRequest + order_id.ID + "=" + order_id.Value + "&";
            ccaRequest = ccaRequest + amount.ID + "=" + amount.Value + "&";
            ccaRequest = ccaRequest + currency.ID + "=" + currency.Value + "&";
            ccaRequest = ccaRequest + redirect_url.ID + "=" + redirect_url.Value + "&";
            ccaRequest = ccaRequest + cancel_url.ID + "=" + cancel_url.Value + "&";
            ccaRequest = ccaRequest + billing_name.ID + "=" + billing_name.Value + "&";
            ccaRequest = ccaRequest + billing_address.ID + "=" + billing_address.Value + "&";
            ccaRequest = ccaRequest + billing_city.ID + "=" + billing_city.Value + "&";
            ccaRequest = ccaRequest + billing_state.ID + "=" + billing_state.Value + "&";
            ccaRequest = ccaRequest + billing_zip.ID + "=" + billing_zip.Value + "&";
            ccaRequest = ccaRequest + billing_country.ID + "=" + billing_country.Value + "&";
            ccaRequest = ccaRequest + billing_tel.ID + "=" + billing_tel.Value + "&";
            ccaRequest = ccaRequest + billing_email.ID + "=" + billing_email.Value + "&";
            ccaRequest = ccaRequest + delivery_name.ID + "=" + delivery_name.Value + "&";
            ccaRequest = ccaRequest + delivery_address.ID + "=" + delivery_address.Value + "&";
            ccaRequest = ccaRequest + delivery_city.ID + "=" + delivery_city.Value + "&";
            ccaRequest = ccaRequest + delivery_state.ID + "=" + delivery_state.Value + "&";
            ccaRequest = ccaRequest + delivery_zip.ID + "=" + delivery_zip.Value + "&";
            ccaRequest = ccaRequest + delivery_country.ID + "=" + delivery_country.Value + "&";
            ccaRequest = ccaRequest + delivery_tel.ID + "=" + delivery_tel.Value + "&";
            ccaRequest = ccaRequest + merchant_param1.ID + "=" + merchant_param1.Value + "&";
            ccaRequest = ccaRequest + merchant_param2.ID + "=" + merchant_param2.Value + "&";
            ccaRequest = ccaRequest + merchant_param3.ID + "=" + merchant_param3.Value + "&";
            ccaRequest = ccaRequest + merchant_param4.ID + "=" + merchant_param4.Value + "&";
            ccaRequest = ccaRequest + merchant_param5.ID + "=" + merchant_param5.Value + "&";
            ccaRequest = ccaRequest + promo_code.ID + "=" + promo_code.Value + "&";
            ccaRequest = ccaRequest + customer_identifier.ID + "=" + customer_identifier.Value;
            strEncRequest = ccaCrypto.Encrypt(ccaRequest, workingKey);

            NameValueCollection data = new NameValueCollection();
            data.Add("encRequest", strEncRequest);
            data.Add("access_code", strAccessCode);
            RedirectAndPOST(this.Page, "https://test.ccavenue.com/transaction.do?command=initiateTransaction", data);
        }

        public static void RedirectAndPOST(Page page, string destinationUrl,
                                   NameValueCollection data)
        {
            //Prepare the Posting form
            string strForm = PreparePOSTForm(destinationUrl, data);
            //Add a literal control the specified page holding 
            //the Post Form, this is to submit the Posting form with the request.
            page.Controls.Add(new LiteralControl(strForm));
        }
        private static String PreparePOSTForm(string url, NameValueCollection data)
        {
            //Set a name for the form
            string formID = "PostForm";
            //Build the form using the specified data to be posted.
            StringBuilder strForm = new StringBuilder();
            strForm.Append("<form id=\"" + formID + "\" name=\"" +
                           formID + "\" action=\"" + url +
                           "\" method=\"POST\">");

            foreach (string key in data)
            {
                strForm.Append("<input type=\"hidden\" name=\"" + key +
                               "\" value=\"" + data[key] + "\">");
            }

            strForm.Append("</form>");
            //Build the JavaScript which will do the Posting operation.
            StringBuilder strScript = new StringBuilder();
            strScript.Append("<script language='javascript'>");
            strScript.Append("var v" + formID + " = document." +
                             formID + ";");
            strScript.Append("v" + formID + ".submit();");
            strScript.Append("</script>");
            //Return the form and the script concatenated.
            //(The order is important, Form then JavaScript)
            return strForm.ToString() + strScript.ToString();
        }
    }
}