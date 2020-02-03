<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="NameListUI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="firstNameTextBox" runat="server" Height="17px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Middle Name"></asp:Label>
        <asp:TextBox ID="middleNameTextBox" runat="server" Height="17px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="lastNameTextBox" runat="server" Height="17px"></asp:TextBox>
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Show All"></asp:Label>
    
    </div>
    &nbsp;
        <asp:ListBox ID="displayListBox" runat="server" Height="170px" Width="162px"></asp:ListBox>
    </form>
</body>
</html>
