<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Horaire.aspx.cs" Inherits="Horaire" %>

<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">
       <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page pour Horaire</h2> 
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label7" runat="server" Text="Code"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList5" cssClass="input--style-4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label1" runat="server" Text="Cours"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList1" cssClass="input--style-4" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label2" runat="server" Text="Departement"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList2" cssClass="input--style-4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label3" runat="server" Text="Enseignent"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList3" cssClass="input--style-4" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        </div>
        </div>

        <div class="input-group">
        <asp:Label cssClass="label" ID="Label5" runat="server" Text="Salle"></asp:Label>
        <div class="rs-select2 js-select-simple select--no-search">
        <asp:DropDownList ID="DropDownList4" cssClass="input--style-4" runat="server" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        </div>
        </div>
        
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label6" runat="server" Text="Date_Debut"></asp:Label>
        <asp:TextBox cssClass="input--style-4" ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label4" runat="server" Text="Date_fin"></asp:Label>;
        <asp:TextBox cssClass="input--style-4" ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
        </div>

        <div class="p-t-5 b-w">
        <asp:Button ID="Button1" cssClass="btn btn--radius-2 btn--blue" runat="server" OnClick="Button1_Click" Text="Ajouter" />
        <asp:Button ID="Button2" cssClass="btn btn--radius-2 btn--blue" runat="server" Text="Modifier" OnClick="Button2_Click" />
        </div>
         </div>
         </div>
        </div>
    </div>
 </asp:Content>
