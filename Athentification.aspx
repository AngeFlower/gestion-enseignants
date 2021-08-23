<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Athentification.aspx.cs" Inherits="Athentification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="mdi/css/materialdesignicons.min.css" rel="stylesheet" />
    <link href="login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Login</h1>
            </div>
            <div class="main">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                    <span class='d-flex'>
                        <i class="mdi mdi-account"></i>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </span>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    <span class='d-flex'>
                        <i class="mdi mdi-lock"></i>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
                    </span>
                </div>
                
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Connexion" />
                
            </div>
        </div>
    </form>
</body>
</html>
