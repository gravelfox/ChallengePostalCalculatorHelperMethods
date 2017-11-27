<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthBox" runat="server" AutoPostBack="True" OnTextChanged="elementChanged"></asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightBox" runat="server" AutoPostBack="True" OnTextChanged="elementChanged"></asp:TextBox>
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthBox" runat="server" AutoPostBack="True" OnTextChanged="elementChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="elementChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="elementChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="elementChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="priceLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
