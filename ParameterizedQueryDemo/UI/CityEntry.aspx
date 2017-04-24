<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="ParameterizedQueryDemo.UI.CityEntry" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Title of the document</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="City Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="cNameTextBox" runat="server"></asp:TextBox></td>
                
            </tr>
           <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="About"></asp:Label></td>
                <td>
                    <asp:TextBox ID="aboutTextBox" runat="server"></asp:TextBox></td>
                
            </tr>
          <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Country"></asp:Label></td>
                <td>
                    <asp:TextBox ID="countryTextBox" runat="server"></asp:TextBox></td>
                
            </tr>
        <tr>
            <td>
                <asp:Button ID="saveButton1" runat="server" Text="Save" OnClick="saveButton1_Click" />
            </td>
            <td>
                <asp:Label ID="msgLabel" runat="server" Text="msg"></asp:Label>
            </td>
        </tr>
        </table>
    </div>
        
    </form>
</body>
</html>
