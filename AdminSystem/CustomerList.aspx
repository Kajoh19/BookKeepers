<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1003px;
            height: 450px;
            position: absolute;
            left: 10px;
            top: 15px;
            bottom: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="258px" Width="381px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click1" />
            <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click1" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter an email"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnCancel_Click" Text="Clear" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
