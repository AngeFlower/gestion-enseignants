<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Departement.aspx.cs" Inherits="Departement" %>

<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">
    <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page pour Departement</h2>
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label3" runat="server" Text="Code"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList2" cssClass="input--style-4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label1" runat="server" Text="Faculte"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList1" cssClass="input--style-4" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label2" runat="server" Text="Departement"></asp:Label>
        <asp:TextBox cssClass="input--style-4" ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div class="p-t-5 b-w">
        <asp:Button ID="Button1" cssClass="btn btn--radius-2 btn--blue" runat="server" OnClick="Button1_Click" Text="Ajouter" />
        <asp:Button ID="Button2" cssClass="btn btn--radius-2 btn--blue" runat="server" OnClick="Button2_Click" Text="Modifier" />
        </div>
</div>
</div>
</div>
</div>
 </asp:Content>
