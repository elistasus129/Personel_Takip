Imports System.Data.OleDb
Public Class Form2
    Dim baglan As OleDbConnection
    Dim komut As New OleDbCommand
    Dim secilen As String
    Dim cins As String
    Dim kaynak As String = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=proje.accdb"

    

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Len(TextBox2.Text) < 12 Then
            MsgBox("T.c. 11 haneden küçüktür")
        Else
            BindingSource1.EndEdit()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BindingSource1.AddNew()
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub ÇıkışToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Form1.Show()

    End Sub


    Private Sub TelifHakkıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelifHakkıToolStripMenuItem.Click
        MsgBox("Bu programın telif hakları saklıdır.")

    End Sub

    Private Sub ProgramHakkındaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramHakkındaToolStripMenuItem.Click
        MsgBox("Bu programın çalışma saatlerinde kaytarmaya çalışan kişilerin maaşlarından ceza olarak indirmek amaçlı yazılmıştır.")
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.MaxLength = 11
        Dim baglan As New OleDbConnection(kaynak)
        Dim adap As New OleDbDataAdapter("select * from personel", kaynak)
        Dim tablo As New DataTable()
        Dim ds As New DataSet()
        adap.Fill(ds, "tablo")
        ds.Tables.Add(tablo)
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = ds.Tables(0).TableName
        DataGridView1.DataSource = BindingSource1
        TextBox1.DataBindings.Add("text", BindingSource1, "personel_no")
        TextBox2.DataBindings.Add("text", BindingSource1, "tc")
        TextBox3.DataBindings.Add("text", BindingSource1, "adi")
        TextBox4.DataBindings.Add("text", BindingSource1, "soyadi")
        TextBox6.DataBindings.Add("text", BindingSource1, "departman")
        TextBox7.DataBindings.Add("text", BindingSource1, "genel_maas")
        TextBox8.DataBindings.Add("text", BindingSource1, "cezali_maas")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BindingSource1.MoveFirst()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BindingSource1.MovePrevious()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BindingSource1.MoveNext()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        BindingSource1.MoveLast()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        If TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
            If RadioButton1.Checked = True Then
                komut.CommandText = "insert into personel (personel_no,tc,adi,soyadi,cinsiyet,departman,genel_maas,cezali_maas) values ( ' " & TextBox1.Text & " ', ' " & TextBox2.Text & " ','" & TextBox3.Text & " ' , ' " & TextBox4.Text & " ' , ' " & RadioButton1.Text & "','" & TextBox6.Text & " ', ' " & TextBox7.Text & " ' , ' " & TextBox8.Text & " ' ) "
            Else
                komut.CommandText = "insert into personel (personel_no,tc,adi,soyadi,cinsiyet,departman,genel_maas,cezali_maas) values ( ' " & TextBox1.Text & " ', ' " & TextBox2.Text & " ','" & TextBox3.Text & " ' , ' " & TextBox4.Text & " ' , ' " & RadioButton2.Text & "','" & TextBox6.Text & " ', ' " & TextBox7.Text & " ' , ' " & TextBox8.Text & " ' ) "
            End If
            komut.ExecuteNonQuery()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            MessageBox.Show("Kayıt Yapıldı..")

        Else
            MessageBox.Show("Lüften Tüm alanları doldurunuz....")
        End If
        baglan.Close()
        DataGridView1.Refresh()
    End Sub

    Private Sub ÇıkışToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()

    End Sub

    Private Sub SeriPortİleDakikaÜzerindenMaasHesaplamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeriPortİleDakikaÜzerindenMaasHesaplamaToolStripMenuItem.Click
        Form5.ShowDialog()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.ShowDialog()

    End Sub

    Private Sub GeriDönToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeriDönToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub ÇıkışToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem1.Click
        Application.Exit()

    End Sub

  
    Private Sub İlkKayıtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles İlkKayıtToolStripMenuItem.Click
        BindingSource1.MoveFirst()

    End Sub

    Private Sub ÖncekiKayıtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖncekiKayıtToolStripMenuItem.Click
        BindingSource1.MovePrevious()
    End Sub

    Private Sub SonrakiKayıtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonrakiKayıtToolStripMenuItem.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub SonKayıtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonKayıtToolStripMenuItem.Click
        BindingSource1.MoveLast()
    End Sub

    

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingSource1.RemoveAt(BindingSource1.Position)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        BindingSource1.CancelEdit()
    End Sub

    Private Sub SilmeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilmeToolStripMenuItem1.Click
        BindingSource1.RemoveAt(BindingSource1.Position)
    End Sub

    Private Sub YapılanİşlemdenVazgeçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YapılanİşlemdenVazgeçToolStripMenuItem.Click
        BindingSource1.RemoveAt(BindingSource1.Position)
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

   


    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GüncelleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GüncelleToolStripMenuItem.Click
        Form7.ShowDialog()
    End Sub

    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        Form6.ShowDialog()
    End Sub

    Private Sub KayıtSayısıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KayıtSayısıToolStripMenuItem.Click
        Dim liste As Integer = BindingSource1.Count
        MsgBox(liste.ToString())
    End Sub

    Private Sub AktifKaydınNosuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktifKaydınNosuToolStripMenuItem.Click
        Dim aktif As Integer = BindingSource1.Position + 1
        MsgBox(aktif.ToString)
    End Sub

    Private Sub DatasetteAktifKaydınGörüntüleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatasetteAktifKaydınGörüntüleToolStripMenuItem.Click
        Dim a As DataRowView
        a = CType(BindingSource1.Current, DataRowView)
        Dim personel_no As String = a("personel_no").ToString()
        Dim adi As String = a("adi").ToString()
        Dim soyadi As String = a("soyadi").ToString()
        MessageBox.Show("Personel No=" & personel_no & "  " & "" & "adi=" & adi & "  " & "soyadi=" & soyadi)

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

  
  
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim adap As New OleDbDataAdapter("select * from personel where adi like'%" & TextBox5.Text & "%'", baglan)
        Dim tablo As New DataTable
        adap.Fill(tablo)
        Dim data As New DataSet
        data.Tables.Add(tablo)
        BindingSource1.DataSource = data.Tables(0)
        DataGridView1.DataSource = BindingSource1
        baglan.Close()
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class