<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Faculte.aspx.cs" Inherits="Faculte" %>


<asp:Content ContentPlaceHolderID="ContentPlaceholder1" ID="PlaceHolder1" runat="server">
  
        <div class="page-wrapper font-poppins">
        <div class="wrapper">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Page pour Faculte</h2>     
        <div class="input-group">
        <asp:Label cssClass="label" ID="Label1" runat="server" Text="Nom"></asp:Label>
        <asp:TextBox cssClass="input--style-4" ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div class="p-t-5 b-w">
        <asp:Button cssClass="btn btn--radius-2 btn--blue" ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Ajouter" />
        </div>
        </div>
        </div>
        </div>
        </div>
</asp:Content>
