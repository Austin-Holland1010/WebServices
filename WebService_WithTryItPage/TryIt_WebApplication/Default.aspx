<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt_WebApplication._Default" ValidateRequest="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    Austin Holland&#39;s Project 3 TryIt Page</p>
<p>
    Service #1: Stemming</p>
<p>
    A) Discription: This service takes a string as input and teturns a string with all words being stemmed. So any prefixes and suffixes are removed.</p>
<p>
    B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
<p>
    C) string Stemming(string s); which returns a string with all words being stemmed</p>
<p>
    D) Enter a string to be stemmed. Click the &quot;Invoke Service&quot; button to use the service.<asp:TextBox ID="txtbox_Stemming" runat="server" OnTextChanged="txtbox_Stemming_TextChanged" Width="453px"></asp:TextBox>
    <asp:Button ID="btn_Stemming" runat="server" Text="Invoke Service" OnClick="btn_Stemming_Click" />
</p>
<p>
    <asp:Label ID="txtbox_Stemming_Result" runat="server" Text="[Result to be shown here for the Stemming service]"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Service #2: WordFilter</p>
<p>
    A) This service analizes a string of words and fiters out the function words (stop words). It also filters out XML element tag names and attribute names.<meta charset="utf-8" /></p>
    <p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
    <p>
        C)string WordFilter(string s); which returns a string with all function words and XML tags removed.</p>
    <p>
        D) Enter a string to be filtered. Click the &quot;Invoke Service&quot; button to use the service.</p>
    <p>
        <asp:TextBox ID="txtbox_WordFilter_input" runat="server" OnTextChanged="txtbox_WordFilter_input_TextChanged" Width="454px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_WordFilter" runat="server" OnClick="btn_WordFilter_Click" Text="Invoke Service" />
    </p>
    <p>
        <asp:Label ID="lbl_WordFilter_Result" runat="server" Text="[Result to be shown here for WordFilter service]"></asp:Label>
    </p>

</asp:Content>
