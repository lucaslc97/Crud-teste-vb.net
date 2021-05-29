<%@ Page Title="Home Page" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Crud_teste_vb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">
                     <asp:GridView
                        ID="GridView1"
                        runat="server"
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
                                        OnClick="btnEditar_Click">
                                    </asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            

                        </Columns>
                    </asp:GridView>
    </div>

   

</asp:Content>
