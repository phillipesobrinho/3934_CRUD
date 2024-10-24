Imports System.Data.SqlClient

Public Class Form1
    Dim ligacao As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
    AppDomain.CurrentDomain.BaseDirectory() + "bdalunos.mdf;Integrated Security=True;Connect Timeout=30")

    Dim comando As New SqlCommand
    Dim adapter As New SqlDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.Open()
        mostra_dados()
    End Sub
    Sub mostra_dados()
        Dim dt As DataTable = New DataTable()
        adapter = New SqlDataAdapter("select * from alunos", ligacao)
        adapter.Fill(dt)

        dg_alunos.DataSource = dt
        dg_alunos.Columns(0).HeaderText = "Número"
        dg_alunos.Columns(1).HeaderText = "Nome"
        dg_alunos.Columns(2).HeaderText = "Nota"

        dg_alunos.Columns(0).Width = 80
        dg_alunos.Columns(1).Width = 150
        dg_alunos.Columns(2).Width = 50

    End Sub

    Private Sub dg_alunos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_alunos.RowHeaderMouseClick
        Dim linha As DataGridViewRow
        linha = dg_alunos.Rows(e.RowIndex)

        txt_id.Text = linha.Cells(0).Value.ToString
        txt_nome.Text = linha.Cells(1).Value.ToString
        msk_nota.Text = linha.Cells(2).Value.ToString

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        comando = New SqlCommand("update alunos set nome=@no, nota=@not where id=@id", ligacao)
        comando.Parameters.AddWithValue("@id", txt_id.Text)
        comando.Parameters.AddWithValue("@no", txt_nome.Text)
        comando.Parameters.AddWithValue("@not", msk_nota.Text)
        comando.ExecuteNonQuery()

        MsgBox("Update efetuado.", MsgBoxStyle.Information, "Update")
        mostra_dados()
    End Sub
    Sub limpar()
        txt_id.Clear()
        txt_nome.Clear()
        msk_nota.Clear()
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If (btn_create.Text = "Create") Then
            limpar()
            btn_create.Text = "Save"
        Else
            comando = New SqlCommand("insert into alunos (nome,nota) values(@no,@not)", ligacao)
            comando.Parameters.AddWithValue("@no", txt_nome.Text)
            comando.Parameters.AddWithValue("@not", msk_nota.Text)
            comando.ExecuteNonQuery()

            MsgBox("Registo inserido.", MsgBoxStyle.Information, "Insert")
            btn_create.Text = "Create"
            mostra_dados()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If (txt_id.Text <> "") Then
            Try
                comando = New SqlCommand("delete from alunos where id=@id", ligacao)
                comando.Parameters.AddWithValue("@id", txt_id.Text)
                comando.ExecuteNonQuery()

                MsgBox("Registo eliminado", MsgBoxStyle.Information, "Eliminar")
                limpar()
                mostra_dados()
            Catch ex As Exception
                MsgBox("Erro ao eliminar o registo", MsgBoxStyle.Critical, "Eliminar")
            End Try

        Else
            MsgBox("Erro ao eliminar o registo", MsgBoxStyle.Critical, "Eliminar")
        End If
    End Sub
End Class
