<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lease_Slip.aspx.cs" Inherits="MarinaApp.Lease_Slip" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 >Available Slips List     <asp:DropDownList ID="uxDocks" runat="server" AutoPostBack="True" Width="275px">
    </asp:DropDownList>

    <asp:Button ID="btnLease" runat="server" OnClick="btnLease_Click" Text="Lease" />
    </h3>
 
    
    <asp:GridView ID="uxSelectedSlips" runat="server" DataKeyNames="ID" Width="494px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="uxSelectedSlips_SelectedIndexChanged" AutoGenerateSelectButton="True">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" BorderColor="#FFFFCC" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <div>
        <p>
            Your Leased Slips
        </p>
        <asp:GridView ID="uxLease" runat="server" Width="439px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    </div>
    <asp:Label ID="lblSelectedSlipID" runat="server" Visible="False"></asp:Label>

</asp:Content>
