Imports System.Data.SqlClient

Public Class Editar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If (Not IsPostBack) Then

            If Not Session("idCliente") Is Nothing Then



                Dim stringSelecionaTodos As String = "Select * from Cliente where CLI_ID = " + Session("idCliente")
                Dim conn As SqlConnection = Connection()


                If Not stringSelecionaTodos.Equals("") Then

                    Using cmd As SqlCommand = New SqlCommand(stringSelecionaTodos, conn)

                        'Executando comando Sql acima
                        Using sdr As SqlDataReader = cmd.ExecuteReader
                            While sdr.Read

                                Dim cliente As New Cliente
                                id.Text = sdr("CLI_ID").ToString
                                nome.Text = sdr("CLI_NOME").ToString
                                dataNascimentoCliente.Text = sdr("CLI_DATANASCIMENTO").ToString
                                ativo.Checked = sdr("CLI_ATIVO")

                            End While

                        End Using
                    End Using

                End If
            End If
        End If
    End Sub

    Public Shared Function Connection() As SqlConnection
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-C99AVKK;Initial Catalog=Crud_teste;Integrated Security=True")
        conn.Open()
        Return conn
    End Function

    Protected Sub Editar(sender As Object, e As EventArgs) Handles BtnConfirma.Click



        Dim conn As String = "update CLIENTE set CLI_NOME = @nome, CLI_DATANASCIMENTO = @dtNascimento, CLI_ATIVO = @ativo where CLI_ID = " + Session("idCliente")

        If Not nome.Text Is "" And Not dataNascimentoCliente.Text Is "" Then

            Dim comando As SqlConnection = Connection()
            Dim mcd As New SqlCommand(conn, comando)



            mcd.Parameters.Add(New SqlParameter("@nome", nome.Text))
            mcd.Parameters.Add(New SqlParameter("@dtNascimento", dataNascimentoCliente.Text))
            mcd.Parameters.Add(New SqlParameter("@ativo", ativo.Checked))


            comando.Close()

            comando.Open()

            mcd.ExecuteNonQuery()

            Dim script As String = "alert('Cliente editado com Sucesso.');"
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Alert", script, True)

        End If
    End Sub

    Protected Sub Excluir(sender As Object, e As EventArgs) Handles BtnDeletar.Click
        Dim conn As String = "delete CLIENTE where CLI_ID = " + Session("idCliente")



        Dim comando As SqlConnection = Connection()
        Dim mcd As New SqlCommand(conn, comando)

        comando.Close()

        comando.Open()

        mcd.ExecuteNonQuery()

        Dim script As String = "alert('Cliente deletado.');"
        ClientScript.RegisterClientScriptBlock(Me.GetType(), "Alert", script, True)



    End Sub
End Class