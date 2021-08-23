<%@ Page Language="C#"  MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Salle.aspx.cs" Inherits="Salle" %>

<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">
            <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page pour Salle</h2>
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label3" runat="server" Text="Code"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList1" cssClass="input--style-4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label1" runat="server" Text="Nom"></asp:Label>
        <asp:TextBox cssClass="input--style-4" ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label2" runat="server" Text="Bloc"></asp:Label>
        <asp:TextBox cssClass="input--style-4" ID="TextBox2" runat="server"></asp:TextBox>
        </div>

        <div class="p-t-5 b-w">
        <asp:Button cssClass="btn btn--radius-2 btn--blue" ID="Button1" runat="server" OnClick="Button1_Click" Text="Ajouter" />
        <asp:Button cssClass="btn btn--radius-2 btn--blue" ID="Button2" runat="server" OnClick="Button2_Click" Text="Modifier" />
        </div>
        </div>
        </div>
        </div>
        </div>
    
</asp:Content>
