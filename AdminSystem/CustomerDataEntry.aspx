<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click1" />
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="79px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblUserPassword" runat="server" Text="Password" width="79px"></asp:Label>
        <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="79px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblBudget" runat="server" Text="Budget" width="79px"></asp:Label>
        <asp:TextBox ID="txtBudget" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
