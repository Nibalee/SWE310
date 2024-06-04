<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chatbotPage.aspx.cs" Inherits="Assignemnt1.chatbotPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Adding the external css to our HTML page-->
    <link rel="stylesheet" href="style.css">
    <!-- Linking our javascript script to control the dispaly of label text-->
    <script src="script.js" defer></script>
</head>
<body>
    <form id="form1" runat="server">
        <!--Main Container to contain all the components of the website-->
        <div class="main-container">
            <!--Display the title and the subtitle-->
            <h1 id="title">🌚ASTRONOMY CHATBOT🌞</h1>
            <h5 id="subtitle">⭐ASK ME ABOUT ASTRONOMY AND I WILL ANSWER ⭐</h5>
            <!--a content div to contain the TextBox and the button for a better layout-->
            <div class="content">
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your question here..."></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Submit Question" OnClick="Button1_Click" role="button" Height="51px"/>
            </div>
            <!--A div container for label text to allocate a fix height for it since 
                it will be hidden in case the label text is empty-->
            <div class="label-container">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
