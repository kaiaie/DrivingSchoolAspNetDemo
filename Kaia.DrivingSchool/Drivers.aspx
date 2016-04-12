<%@ Page Title="Drivers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="Kaia.DrivingSchool.Drivers" %>
<%@ Import Namespace="Kaia.DrivingSchool.Data.Repositories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" EnableViewState="True">
    <asp:ObjectDataSource ID="DriverDataSource" runat="server" OnObjectCreating="DriverDataSource_ObjectCreating" SelectMethod="SelectAll" TypeName="Kaia.DrivingSchool.Data.Repositories.IDriverRepository" >
    </asp:ObjectDataSource>

    <asp:GridView ID="DriverGrid" runat="server" DataSourceID="DriverDataSource" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
        </Columns>
    </asp:GridView>
</asp:Content>
