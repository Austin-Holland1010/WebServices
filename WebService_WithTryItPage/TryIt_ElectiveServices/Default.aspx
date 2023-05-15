<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt_ElectiveServices._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    Austin Holland&#39;s Project 3 Elective TryIt Page</p>
<p>
    Service #1: Text Sorting Service</p>
<p>
    A) Discription: This service takes a string and integer as input. The integer is used to determine what type of sorting algorithm to use (1 = bubble sort, 2 = selection sort). The string is sorted in alphabetical order.</p>
<p>
    B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
<p>
    C) string String_Sort(string s, int sortingMethod);&nbsp; which returns a string with all words sorted.</p>
<p>
    D) Enter a string to be sorted:<asp:TextBox ID="txtbox_StringSort1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="316px"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp; Enter a number to select which sorting algorithm to use: 1 = bubble sort&nbsp; 2 = selection sort.&nbsp;<asp:TextBox ID="txtbox_String_Sort2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="109px"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp; Click the &quot;Invoke Service&quot; button to use the service.&nbsp;<asp:Button ID="btn_String_Sort" runat="server" OnClick="Button1_Click" Text="Invoke Service" />
</p>
<p>
    <asp:Label ID="lbl_String_Sort" runat="server" Text="[Result to be shown here for String_Sort service]"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        Service #2: Character Count Service</p>
    <p>
        A) Discription: This service takes a string as input and counts the number of characters in the string(excluding spaces).</p>
    <p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a></p>
    <p>
        C) int CharacterCounter(string s); returns the number of characters in the string(excluding spaces)</p>
    <p>
        D) Enter a string that you wish to know the number of characters in:
        <asp:TextBox ID="txtbox_CharacterCounter" runat="server" OnTextChanged="txtbox_CharacterCounter_TextChanged" Width="405px"></asp:TextBox>
</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_CharacterCounter" runat="server" OnClick="btn_CharacterCounter_Click" Text="Invoke Service" />
&nbsp;
        <asp:Label ID="lbl_CharacterCounter" runat="server" Text="[Result to be shown here for character counter service]"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        Service #3: Password Service</p>
    <p>
        A) Discription: This service is a simple service that takes a string as input. This string is then checked aginst a list of a few valid passwords(already predetermined)</p>
    <p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a> </p>
    <p>
        C) boolean Password(string s); returns a true or false depending on if the password entered is valid or invalid</p>
    <p>
        D) Enter the password:
        <asp:TextBox ID="txtbox_Password" runat="server" Width="367px" OnTextChanged="txtbox_Password_TextChanged"></asp:TextBox>
        <asp:Button ID="btn_Password" runat="server" Text="Invoke Service" OnClick="btn_Password_Click" />
</p>
    <p>
        &nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lbl_Password" runat="server" Text="[Result to be shown here for the password service]"></asp:Label>
</p>
<p>
        &nbsp;</p>
<p>
        Service #4: Uppercase/Lowercase/DoubleSpace Service</p>
<p>
        A) Discription: This service takes a string as input and makes it uppercase, lowercase, or double spaced based on the action chosen. To choose an action the integer inputted with the service determines what will happen. (0 = uppercase, 1 = lowercase, 2 = double spaced)</p>
<p>
        B) Service URL: <a href="http://localhost:50265/Service1.svc">http://localhost:50265/Service1.svc</a>
</p>
<p>
        C) string Upper_Lower_DoubleSpace(string s, int action); returns a string with the action performed on the string</p>
<p>
        D) Enter a string:
        <asp:TextBox ID="txtbox1_UpLowDouble" runat="server" OnTextChanged="TextBox1_TextChanged1" Width="408px"></asp:TextBox>
</p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp; Enter an integer (0 = uppercase, 1 = lowercase, 2 = double spaced): &nbsp;<asp:TextBox ID="txtbox2_UpLowDouble" runat="server" Width="187px"></asp:TextBox>
</p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btn_UpLowDouble" runat="server" OnClick="btn_UpLowDouble_Click" Text="Invoke Service" Width="134px" />
</p>
<p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_UpLowDouble" runat="server" Text="[Result to be shown here for the Uppercase/Lowercase/DoubleSpace Service]"></asp:Label>
</p>

</asp:Content>
