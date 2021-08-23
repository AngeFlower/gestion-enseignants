<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cours_Departement.aspx.cs" Inherits="Cours_Departement" %>

<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">

            <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page pour Cours_dep</h2> 
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label1" runat="server" Text="Departement"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList1" cssClass="input--style-4" runat="server">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label2" runat="server" Text="Cours"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList2" cssClass="input--style-4" runat="server">
        </asp:DropDownList>
        </div>
        </div>

        <div class="p-t-5 b-w">
        <asp:Button cssClass="btn btn--radius-2 btn--blue" ID="Button1" runat="server" OnClick="Button1_Click1" Text="Ajouter" />
        </div>
</div>
</div>
</div>
</div>
</asp:Content>
