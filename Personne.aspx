<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Personne.aspx.cs" Inherits="Personne" %>

<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">
    <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page Personne</h2>
                        <div class="input-group">
                            <asp:Label cssClass="label" ID="Label11" runat="server" Text="Code"></asp:Label>

                            <div class="rs-select2 js-select-simple select--no-search">
                                <asp:DropDownList ID="DropDownList3" cssClass="input--style-4" runat="server" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="input-group">
                            <asp:Label cssClass="label" ID="Label1" runat="server" Text="Nom"></asp:Label>

                            <asp:TextBox cssClass="input--style-4" ID="TextBox4" runat="server"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label2" runat="server" Text="Prenom"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox5" runat="server"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label3" runat="server" Text="status"></asp:Label>

                            <div class="rs-select2 js-select-simple select--no-search">
                                <asp:DropDownList class="input--style-4" ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                                <asp:ListItem>choisir le statut</asp:ListItem>
                                <asp:ListItem>Enseignent</asp:ListItem>
                                <asp:ListItem>Utilisateur</asp:ListItem>
                                </asp:DropDownList>

                            </div>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label4" runat="server" Text="Telephone"></asp:Label>
                            <asp:TextBox class="input--style-4" ID="TextBox1" runat="server"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label5" runat="server" Text="Email"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox2" runat="server" TextMode="Email"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label6" runat="server" Text="Genre"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox3" runat="server"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label7" runat="server" Text="Profil"></asp:Label>

                            <div class="rs-select2 js-select-simple select--no-search">
                                <asp:DropDownList class="input--style-4" ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                                    <asp:ListItem>chosir le profil</asp:ListItem>
                                    <asp:ListItem>Admin</asp:ListItem>
                                    <asp:ListItem>SimpleAdm</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label8" runat="server" Text="Degre"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox8" runat="server"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label9" runat="server" Text="Password"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>
                        </div>

                        <div class="input-group">
                            <asp:Label class="label" ID="Label10" runat="server" Text="Username"></asp:Label>

                            <asp:TextBox class="input--style-4" ID="TextBox10" runat="server"></asp:TextBox>
                        </div>

                        <div class="p-t-5 b-w">
                            <asp:Button ID="Button1" cssClass="btn btn--radius-2 btn--blue" runat="server" Text="Ajouter" OnClick="Button1_Click1" />

                            <asp:Button ID="Button2" cssClass="btn btn--radius-2 btn--blue" runat="server" Text="Modifier" OnClick="Button2_Click1" />
                        </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>