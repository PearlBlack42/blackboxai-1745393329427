Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ' Pre-fill the database path with simkopkar.mDB assuming it is in the same directory as the executable
        txtDatabasePath.Text = "simkopkar.mDB"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As System.EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Access Database (*.mdb;*.accdb)|*.mdb;*.accdb"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtDatabasePath.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim dbPath As String = txtDatabasePath.Text.Trim()
        Dim oldNIK As String = txtOldNIK.Text.Trim()
        Dim newNIK As String = txtNewNIK.Text.Trim()

        If String.IsNullOrEmpty(dbPath) OrElse String.IsNullOrEmpty(oldNIK) OrElse String.IsNullOrEmpty(newNIK) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};User ID=sa;Password=0711321277;"

        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim tables As String() = {
                    "tagSimpPinjFix",
                    "tblMstKaryawan",
                    "tblTransaksiDtltmp",
                    "tblTtrSimpananTmp",
                    "tmpTagPinjaman",
                    "tmpTagSimpanan",
                    "tblTrAngsuran",
                    "tblTransaksi",
                    "tblTrPermohonanPinjaman",
                    "tblTrPinjaman",
                    "tblTrTagihan",
                    "tblTtrSimpanan"
                }

                Dim totalRowsAffected As Integer = 0
                Dim transaction As OleDbTransaction = conn.BeginTransaction()

                For Each tableName As String In tables
                    Dim cmd As New OleDbCommand($"UPDATE {tableName} SET NIK = ? WHERE NIK = ?", conn, transaction)
                    cmd.Parameters.AddWithValue("?", newNIK)
                    cmd.Parameters.AddWithValue("?", oldNIK)
                    totalRowsAffected += cmd.ExecuteNonQuery()
                Next

                transaction.Commit()

                If totalRowsAffected > 0 Then
                    MessageBox.Show($"Successfully updated {totalRowsAffected} record(s) across all tables.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No records found with the old NIK in any table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
