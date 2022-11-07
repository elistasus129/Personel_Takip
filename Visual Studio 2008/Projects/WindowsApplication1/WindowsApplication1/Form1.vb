Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim baglan As New OleDbConnection
        Dim komut As New OleDbCommand
        Dim adap As New OleDbDataAdapter
        Dim dataset As New DataSet
        baglan.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=uye_panel.accdb")
        komut.CommandText = ("select * from tablo where uye_adi='" + TextBox1.Text + "' and uye_sifre='" + TextBox2.Text + "'")
        baglan.Open()
        komut.Connection = baglan
        adap.SelectCommand = komut
        adap.Fill(dataset, "0")
        Dim a = dataset.Tables(0).Rows.Count
        If a > 0 Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Üyelik adınızı veya üyelik şifrenizi yanlış yazdınız.Tekrar yazınız.", "Yanlış Üyelik Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.ShowDialog()
    End Sub

   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case MessageBox.Show("Çıkmak İstiyormusunuz?", "Çıkış Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Application.Exit()
            Case Else
                Me.Show()
        End Select
    End Sub

  
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    

    Private Sub ÇıkışToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem1.Click
        Select Case MessageBox.Show("Çıkmak İstiyormusunuz?", "Çıkış Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Application.Exit()
            Case Else
                Me.Show()
        End Select

    End Sub

    Private Sub YeniÜyelikToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniÜyelikToolStripMenuItem.Click
        Form4.ShowDialog()

    End Sub

    Private Sub ŞifremiUnuttumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ŞifremiUnuttumToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub
    Private Sub TelifHakkıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelifHakkıToolStripMenuItem.Click
        MsgBox("Bu proje tüm hakları gizlidir.Çoğaltmak kesinlikle yasaktır.Gerekli hükümlere uyulmadığı sürece yasal işlem başlatıcaktır.")
    End Sub

    Private Sub YardımToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YardımToolStripMenuItem.Click
        MsgBox("Bu proje yapanı için irtibata geçmek için m.rmnzoglu@hotmail.com adresine mail atabilirsiniz.")
    End Sub
End Class
