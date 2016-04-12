<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Kaia.DrivingSchool.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Kaia Limited<br />
        7 Newlands Manor Drive<br />
        Clondalkin<br />
        Dublin D22 T3H4<br />
        Ireland<br />
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:support@kaia.ie">mailto:support@kaia.ie</a><br />
    </address>
</asp:Content>
