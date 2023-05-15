<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt_All_Services._Default" ValidateRequest="false"%>

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
    D) Enter a string to be stemmed. Click the &quot;Invoke Service&quot; button to use the service.<asp:TextBox ID="txtbox_Stemming" runat="server" Width="296px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Stemming" runat="server" OnClick="btn_Stemming_Click" Text="Invoke Service" />
    </p>
    <p>
        <asp:Label ID="lbl_Stemming" runat="server" Text="[Result to be shown here for the Stemming service]"></asp:Label>
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
        <asp:TextBox ID="txtbox_WordFilter" runat="server" Width="528px"></asp:TextBox>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_WordFilter" runat="server" OnClick="Button1_Click" Text="Invoke Service" />
    </p>
    <p>
        <asp:Label ID="lbl_WordFilter" runat="server" Text="[Result to be shown here for WordFilter service]"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Below are all elective services</p>
<p>
    Service #3: Text Sorting Service</p>
<p>
    A) Discription: This service takes a string and integer as input. The integer is used to determine what type of sorting algorithm to use (1 = bubble sort, 2 = selection sort). The string is sorted in alphabetical order.</p>
<p>
    B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
<p>
    C) string String_Sort(string s, int sortingMethod);&nbsp; which returns a string with all words sorted.</p>
<p>
    D) Enter a string to be sorted:<asp:TextBox ID="txtbox_StringSort1" runat="server" Width="387px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; Enter a number to select which sorting algorithm to use: 1 = bubble sort&nbsp; 2 = selection sort.<asp:TextBox ID="txtbox_String_Sort2" runat="server"></asp:TextBox>
</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Click the &quot;Invoke Service&quot; button to use the service.<asp:Button ID="btn_String_Sort" runat="server" OnClick="btn_String_Sort_Click" Text="Invoke Service" />
    </p>
    <p>
        <asp:Label ID="lbl_String_Sort" runat="server" Text="[Result to be shown here for Text Sorting service]"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Service #4: Character Count Service</p>
    <p>
        A) Discription: This service takes a string as input and counts the number of characters in the string(excluding spaces).</p>
    <p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
    <p>
        C) int CharacterCounter(string s); returns the number of characters in the string(excluding spaces)</p>
    <p>
        D) Enter a string that you wish to know the number of characters in:
        <asp:TextBox ID="txtbox_CharacterCounter" runat="server" Width="360px"></asp:TextBox>
</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_CharacterCounter" runat="server" OnClick="btn_CharacterCounter_Click" Text="Invoke Service" />
&nbsp;
        <asp:Label ID="lbl_CharacterCounter" runat="server" Text="[Result to be shown here for character counter service]"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Service #5: Password Service</p>
    <p>
        A) Discription: This service is a simple service that takes a string as input. This string is then checked aginst a list of a few valid passwords(already predetermined)</p>
    <p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a> </p>
    <p>
        C) boolean Password(string s); returns a true or false depending on if the password entered is valid or invalid</p>
    <p>
        D) Enter the password:
        <asp:TextBox ID="txtbox_Password" runat="server" Width="253px"></asp:TextBox>
        <asp:Button ID="btn_Password" runat="server" OnClick="btn_Password_Click" Text="Invoke Service" />
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lbl_Password" runat="server" Text="[Result to be shown here for the password service]"></asp:Label>
</p>
    <p>
        &nbsp;</p>
<p>
        Service #6: Uppercase/Lowercase/DoubleSpace Service</p>
<p>
        A) Discription: This service takes a string as input and makes it uppercase, lowercase, or double spaced based on the action chosen. To choose an action the integer inputted with the service determines what will happen. (0 = uppercase, 1 = lowercase, 2 = double spaced)</p>
<p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a>
</p>
<p>
        C) string Upper_Lower_DoubleSpace(string s, int action); returns a string with the action performed on the string</p>
<p>
        D) Enter a string:
        <asp:TextBox ID="txtbox1_UpLowDouble" runat="server" Width="369px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp; Enter an integer (0 = uppercase, 1 = lowercase, 2 = double spaced): &nbsp;&nbsp;<asp:TextBox ID="txtbox2_UpLowDouble" runat="server" Width="160px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_UpLowDouble" runat="server" OnClick="btn_UpLowDouble_Click" Text="Invoke Service" />
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_UpLowDouble" runat="server" Text="[Result to be shown here for the Uppercase/Lowercase/DoubleSpace Service]"></asp:Label>
</p>
    <p>
        &nbsp;</p>

</asp:Content>
