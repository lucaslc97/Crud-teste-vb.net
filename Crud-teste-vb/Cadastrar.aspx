<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.vb" Inherits="Crud_teste_vb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        var myModal = document.getElementById('myModal')
        var myInput = document.getElementById('myInput')

        myModal.addEventListener('shown.bs.modal', function () {
          myInput.focus()
        })
    </script>
    <div class="formulario" >
         
          <div class="form-group">
            <label for="nome">Nome do cliente</label>
           <asp:TextBox ID="nome" CssClass="form-control" runat="server" required="true" ></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="dataNascimentoCliente">Data de nascimento</label>
             <asp:TextBox ID="dataNascimentoCliente" CssClass="form-control" runat="server" required="true" />
          </div>
          <div class="form-group form-check">
            <label class="form-check-label" for="ativo">Cliente ativo?</label>
              <asp:CheckBox id="ativo" runat="server"
                    />
          </div>
          <asp:Button runat="server" text="Cadastrar" class="btn btn-primary" ID="BtnConfirma" OnClick="Cadastrar" />

         


        
    </div>

      


</asp:Content>
