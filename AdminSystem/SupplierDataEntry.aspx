<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 564px"> 
    Testing


    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 121px; top: 72px; position: absolute; height: 20px; width: 169px"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute; height: 26px; width: 75px" Text="Supplier Name"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSupplierName0" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute; height: 56px; width: 166px; bottom: 734px" Text="Supplier Name"></asp:Label>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 13px; top: 117px; position: absolute; width: 75px; height: 26px" Text="Supplier ID"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCost" runat="server" style="z-index: 1; left: 14px; top: 247px; position: absolute; height: 26px; width: 75px; margin-bottom: 3px" Text="Cost"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 15px; top: 291px; position: absolute; height: 26px; margin-top: 1px" Text="Date Added"></asp:Label>
        </p>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 14px; top: 196px; position: absolute; height: 26px" Text="Quantity" width="75px"></asp:Label>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 16px; top: 160px; position: absolute; width: 75px; height: 26px" Text="Phone"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 120px; top: 117px; position: absolute; width: 169px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 118px; top: 162px; position: absolute; width: 169px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 117px; top: 200px; position: absolute; width: 169px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 116px; top: 248px; position: absolute; width: 169px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 114px; top: 293px; position: absolute; width: 169px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 11px; top: 341px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 413px; position: absolute; width: 44px" Text="OK" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 376px; position: absolute"></asp:Label>
        <asp:Button ID="tbnCancel" runat="server" style="z-index: 1; left: 65px; top: 413px; position: absolute; width: 74px" Text="Cancel" />
    </form>
</body>
</html>
