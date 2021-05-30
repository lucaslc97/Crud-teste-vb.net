<%@ Page Title="Home Page" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Crud_teste_vb._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    


    <div class="jumbotron">

        <div class="container">
              <div class="row">
                <div class="col-4">
                       <a runat="server" style="margin-bottom:30px;" id="aCadastrarCliente" class="btn btn-primary" href="~/Cadastrar">Cadastrar novo cliente</a>
                </div>
                <div class="col-4">
                       <label for="Pesquisa">Pesquisar Cliente</label>
                       <asp:TextBox ID="Pesquisa"  runat="server" ></asp:TextBox>
                       <asp:Button   runat="server" text="Pesquisar" class="btn btn-primary" ID="BtnPesquisa" OnClick="Pesquisar" />
                       <asp:Button   runat="server" text="Listar Todos" class="btn btn-primary" ID="ListarTodos" OnClick="ListaTodos" />
                </div>
              </div>
        </div>

        

                     <asp:GridView
                        ID="GridView1"
                        runat="server"
                        style="margin-top:5px;"
                        ClientIDMode="Static"
                        AutoGenerateColumns="False"
                        DataKeyNames="Id"
                        OnRowCommand="GvwLista_RowCommand"
                        OnRowDataBound="GvwLista_RowDataBound"
                        CssClass="table table-striped">
                        <EmptyDataTemplate>
                            Nenhum cliente encontrado
                        </EmptyDataTemplate>
                        <Columns>

                            <asp:BoundField HeaderText="Id" DataField="id" />
                            <asp:BoundField HeaderText="Nome" DataField="nomeCliente" />
                            <asp:BoundField HeaderText="Data de Nascimento" DataField="dataNascimento" />
                            <asp:BoundField HeaderText="Ativo" DataField="ativo" />
                            <asp:TemplateField 
                                ItemStyle-HorizontalAlign="Center"
                                ItemStyle-Width="40px">
                                <ItemTemplate>
                                    <asp:LinkButton
                                        runat="server"
                                        ToolTip="Editar"
                                        id="btnEditar"
                                        CommandName="Editar"
                                        CommandArgument='<%# Eval("id") %>' 
                                        Text="Editar" 
                                        >
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            

                        </Columns>
                    </asp:GridView>
    </div>

   

</asp:Content>
