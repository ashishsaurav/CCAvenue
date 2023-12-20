<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="CCAvenue.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <table width="40%" height="100" border='1' align="center"><caption><font size="4" color="blue"><b>Integration Kit</b></font></caption></table>
        <table width="40%" height="100" border='1' align="center">
            <tr>
                <td>Parameter Name:</td>
                <td>Parameter Value:</td>
            </tr>
            <tr>
                <td colspan="2"> Compulsory information</td>
            </tr>
            <tr>
                <td>TID	:</td>
                <td><input type="text" runat="server" id="tid" readonly /></td>
            </tr>
            <tr>
                <td>Merchant Id</td>
                <td><input type="text" runat="server" id="merchant_id" value="2924200" /></td>
            </tr>
            <tr>
                <td>Order Id</td>
                <td><input type="text" runat="server" id="order_id" value="123654789" /></td>
            </tr>
            <tr>
                <td>Amount</td>
                <td><input type="text" runat="server" id="amount" value="1.00" /></td>
            </tr>
            <tr>
                <td>Currency</td>
                <td><input type="text" runat="server" id="currency" value="INR" /></td>
            </tr>
            <tr>
                <td>Redirect URL</td>
                <td><input type="text" runat="server" id="redirect_url" value="http://localhost/PaymentResponse.aspx" /></td>
            </tr>
            <tr>
                <td>Cancel URL</td>
                <td><input type="text" runat="server" id="cancel_url" value="http://localhost/Payment.aspx" /></td>
            </tr>
            <tr>
                <td colspan="2">Billing information(optional):</td>
            </tr>
            <tr>
                <td>Billing Name</td>
                <td><input type="text" runat="server" id="billing_name" value="Charli" /></td>
            </tr>
            <tr>
                <td>Billing Address:</td>
                <td><input type="text" runat="server" id="billing_address" value="Room no 1101, near Railway station Ambad" /></td>
            </tr>
            <tr>
                <td>Billing City:</td>
                <td><input type="text" runat="server" id="billing_city" value="Indore" /></td>
            </tr>
            <tr>
                <td>Billing State:</td>
                <td><input type="text" runat="server" id="billing_state" value="MP" /></td>
            </tr>
            <tr>
                <td>Billing Zip:</td>
                <td><input type="text" runat="server" id="billing_zip" value="425001" /></td>
            </tr>
            <tr>
                <td>Billing Country:</td>
                <td><input type="text" runat="server" id="billing_country" value="India" /></td>
            </tr>
            <tr>
                <td>Billing Tel:</td>
                <td><input type="text" runat="server" id="billing_tel" value="9899622605" /></td>
            </tr>
            <tr>
                <td>Billing Email:</td>
                <td><input type="text" runat="server" id="billing_email" value="test@gmail.com" /></td>
            </tr>
            <tr>
                <td colspan="2">Shipping information(optional):</td>
            </tr>
            <tr>
                <td>Shipping Name</td>
                <td><input type="text" runat="server" id="delivery_name" value="Chaplin" /></td>
            </tr>
            <tr>
                <td>Shipping Address:</td>
                <td><input type="text" runat="server" id="delivery_address" value="room no.701 near bus stand" /></td>
            </tr>
            <tr>
                <td>shipping City:</td>
                <td><input type="text" runat="server" id="delivery_city" value="Hyderabad" /></td>
            </tr>
            <tr>
                <td>shipping State:</td>
                <td><input type="text" runat="server" id="delivery_state" value="Andhra" /></td>
            </tr>
            <tr>
                <td>shipping Zip:</td>
                <td><input type="text" runat="server" id="delivery_zip" value="425001" /></td>
            </tr>
            <tr>
                <td>shipping Country:</td>
                <td><input type="text" runat="server" id="delivery_country" value="India" /></td>
            </tr>
            <tr>
                <td>Shipping Tel:</td>
                <td><input type="text" runat="server" id="delivery_tel" value="9896426054" /></td>
            </tr>
            <tr>
                <td>Merchant Param1</td>
                <td><input type="text" runat="server" id="merchant_param1" value="additional Info." /></td>
            </tr>
            <tr>
                <td>Merchant Param2</td>
                <td><input type="text" runat="server" id="merchant_param2" value="additional Info." /></td>
            </tr>
            <tr>
                <td>Merchant Param3</td>
                <td><input type="text" runat="server" id="merchant_param3" value="additional Info." /></td>
            </tr>
            <tr>
                <td>Merchant Param4</td>
                <td><input type="text" runat="server" id="merchant_param4" value="additional Info." /></td>
            </tr>
            <tr>
                <td>Merchant Param5</td>
                <td><input type="text" runat="server" id="merchant_param5" value="additional Info." /></td>
            </tr>
            <tr>
                <td>Promo Code</td>
                <td><input type="text" runat="server" id="promo_code" /></td>
            </tr>
            <tr>
                <td>Customer Id:</td>
                <td><input type="text" runat="server" id="customer_identifier" /></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button runat="server" ID="checkout" Text="Checkout" OnClick="checkout_Click" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
