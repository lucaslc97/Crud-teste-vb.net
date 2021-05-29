Imports System.Data.SqlClient

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        If (Not IsPostBack) Then
            ListaClientes()
        End If


    End Sub

    Protected Sub BtnEditar_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Sub ListaClientes()
        Dim listCliente As New List(Of Cliente)
        Dim conn As SqlConnection = Connection()
        Dim stringSelecionaTodos As String = "Select * from Cliente"




        If Not stringSelecionaTodos.Equals("") Then

            Using cmd As SqlCommand = New SqlCommand(stringSelecionaTodos, conn)

                'Executando comando Sql acima
                Using sdr As SqlDataReader = cmd.ExecuteReader
                    While sdr.Read

                        Dim cliente As New Cliente
                        cliente.id = sdr("CLI_ID").ToString
                        cliente.nomeCliente = sdr("CLI_NOME").ToString
                        cliente.dataNascimento = sdr("CLI_DATANASCIMENTO").ToString
                        If sdr("CLI_ATIVO") = True Then
                            cliente.ativo = "Sim"
                        Else
                            cliente.ativo = "Não"
                        End If
                        listCliente.Add(cliente)
                        Session("idCliente") = cliente.id
                    End While

                End Using
            End Using

        End If

        GridView1.DataSource = listCliente
        GridView1.DataBind()
    End Sub

    Protected Sub GvwLista_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        Dim idCliente As String = ""

        If (e.CommandArgument <> "") Then
            idCliente = e.CommandArgument

            Session("idCliente") = idCliente
            Response.Redirect("Editar.aspx")
        End If



    End Sub

    Protected Sub GvwLista_RowDataBound(sender As Object, e As GridViewRowEventArgs)

    End Sub

    Public Shared Function Connection() As SqlConnection
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-C99AVKK;Initial Catalog=Crud_teste;Integrated Security=True")
        conn.Open()
        Return conn
    End Function


End Class