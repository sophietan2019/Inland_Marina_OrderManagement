<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MarinaApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">Firstname:</td>
                <td>
                    <asp:TextBox ID="uxUserFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td style="width:150px">Lastname:</td>
                <td>
                    <asp:TextBox ID="uxUserLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Authenticate" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="uxMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

