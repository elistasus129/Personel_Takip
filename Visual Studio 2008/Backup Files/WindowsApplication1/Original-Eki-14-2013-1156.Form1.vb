Imports System.Data.OleDb
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim com As New OleDbCommand
        Dim adp As New OleDbDataAdapter
        Dim dataset As New DataSet
        con.ConnectionString = ("Provider=Microsoft.Jet.Oledb.12.0;Data Source=D:\uye_panel.mdb")
        com.CommandText = ("select * from tablo where uye_adi='" + TextBox1.Text + "' and uye_sifre='" + TextBox2.Text + "';")
        con.Open()
        com.Connection = con
        adp.SelectCommand = com
        adp.Fill(dataset, "0")
        Dim a = dataset.Tables(0).Rows.Count
        If a > 0 Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("yanlış giriş")
            TextBox1.Clear()
            TextBox2.Clear()

        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case MessageBox.Show("Çıkmak İstiyormusunuz?", "Çıkış Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Application.Exit()
            Case Else
                Me.Show()
        End Select
    End Sub
End Class
