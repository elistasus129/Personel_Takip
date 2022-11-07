Imports System.Data.OleDb

Public Class Form3

    Dim kaynak As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=uye_panel.accdb"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim komut As New OleDbCommand
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        If TextBox2.Text = TextBox3.Text Then
            komut.CommandText = ("Update tablo set uye_sifre='" + TextBox2.Text + "' where uye_adi='" + TextBox1.Text + "'")
            komut.ExecuteNonQuery()
            baglan.Close()
            MessageBox.Show("Şifreniz başarıyla değiştirilmiştir.", "Şifre Değiştirme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Form1.Show()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            MessageBox.Show("Girmiş olduğunuz şifre uyuşmamaktadır. ", "Şifre Değiştirme Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
            TextBox2.Clear()
            TextBox3.Clear()
        End If
    End Sub

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class