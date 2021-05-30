Imports System.Data.SqlClient

Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Not IsPostBack) Then

        End If
    End Sub


    Protected Sub Cadastrar(sender As Object, e As EventArgs) Handles BtnConfirma.Click



        Dim conn As String = "INSERT INTO CLIENTE(CLI_NOME, CLI_DATANASCIMENTO, CLI_ATIVO)
                                            VALUES(@nome, @dtNascimento, @ativo) "





        If Not nome.Text Is "" And Not dataNascimentoCliente.Text Is "" Then
            Dim comando As SqlConnection = Connection()
            Dim mcd As New SqlCommand(conn, comando)

            mcd.Parameters.Add(New SqlParameter("@nome", nome.Text))
            mcd.Parameters.Add(New SqlParameter("@dtNascimento", dataNascimentoCliente.Text))
            mcd.Parameters.Add(New SqlParameter("@ativo", ativo.Checked))


            comando.Close()

            comando.Open()

            mcd.ExecuteNonQuery()

            Session("passaValorModal") = 1

            Dim script As String = "alert('Cliente cadastrado.');"
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "Alert", script, True)


        End If


    End Sub

    Public Shared Function Connection() As SqlConnection
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-C99AVKK;Initial Catalog=Crud_teste;Integrated Security=True")
        conn.Open()
        Return conn
    End Function


End Class