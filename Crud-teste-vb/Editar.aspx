<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Editar.aspx.vb" Inherits="Crud_teste_vb.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="formulario" >
          <div class="form-group">
            <label for="id">Id do cliente</label>
            <asp:TextBox ID="id" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="nome">Nome do cliente</label>
           <asp:TextBox ID="nome" CssClass="form-control" runat="server" required="true" ></asp:TextBox>
          </div>
          <div class="form-group">
            <label for="dataNascimentoCliente">Data de nascimento</label>
             <asp:TextBox ID="dataNascimentoCliente" CssClass="form-control" runat="server" required="true"/>
          </div>
          <div class="form-group form-check">
            <label class="form-check-label" for="ativo">Cliente ativo?</label>
              <asp:CheckBox id="ativo" runat="server"
                    />
          </div>
          <asp:Button runat="server" text="Confirmar" class="btn btn-primary" ID="BtnConfirma" OnClick="Editar" />
          <asp:Button runat="server" text="Deletar Cliente" class="btn btn-danger" ID="BtnDeletar" OnClick="Excluir" />
    </div>

</asp:Content>
