Imports System.Data.OleDb

Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=uye_panel.accdb")
        Dim komut As New OleDbCommand
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        If TextBox2.Text = TextBox3.Text Then
            komut.CommandText = "INSERT INTO tablo (uye_adi,uye_sifre) values ('" + TextBox1.Text + "','" + TextBox2.Text + "')"
            komut.ExecuteNonQuery()
            baglan.Close()
            MessageBox.Show("Kaydınız başarıyla yapılmıştır.", "Şifre Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Form1.Show()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            MessageBox.Show("Girmiş olduğunuz şifre yanlıştır.", "Şifre Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End If
    End Sub

    Private Sub Form4_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class