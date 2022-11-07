Imports System.Data.OleDb

Public Class Form5
    Public saat As Double = 0
    Public dakika As Double = 0
    Public maas As Double = 0
    Dim baglan As OleDbConnection
    Dim komut As New OleDbCommand
    Dim kaynak As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=proje.accdb"
    Dim saa As Integer = 0
    Dim dk As Integer = 0
    Dim sny As Integer = 0

    Public Sub saatler()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim command As New OleDbCommand("select sum(calisilmayan_saat) from hesap where personel_no=" & TextBox7.Text & " ", baglan)
        saat = Convert.ToInt32(command.ExecuteScalar())
        baglan.Close()
    End Sub

    Public Sub dakikalar()

        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim command As New OleDbCommand("select sum(calisilmayan_dakika) from hesap where personel_no =  " & TextBox7.Text & " ", baglan)
        dakika = Convert.ToInt32(command.ExecuteScalar())
        baglan.Close()
    End Sub

    Public Sub maaslar()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim command As New OleDbCommand("select genel_maas from personel where personel_no= " & TextBox7.Text & " ", baglan)
        maas = Convert.ToInt32(command.ExecuteScalar())
        baglan.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sny = sny + 1
        TextBox6.Text = sny

        If sny = 59 Then
            sny = 0
            dk = dk + 1
            TextBox5.Text = dk
            If dk = 59 Then
                dk = 0
                saa = saa + 1
                TextBox4.Text = saat
                If saa = 7 Then
                    Timer1.Stop()
                End If
            End If
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Dim baglan As New OleDbConnection(kaynak)
        Dim adap As New OleDbDataAdapter("select * from hesap", baglan)
        Dim tablo As New DataTable()
        Dim ds As New DataSet()
        adap.Fill(ds, "das")
        ds.Tables.Add(tablo)
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = ds.Tables(0).TableName
        DataGridView1.DataSource = BindingSource1
        TextBox1.DataBindings.Add("text", BindingSource1, "personel_no")
        TextBox2.DataBindings.Add("text", BindingSource1, "tarih")
        TextBox3.DataBindings.Add("text", BindingSource1, "calisilan_gun")
        TextBox4.DataBindings.Add("text", BindingSource1, "calisilmayan_saat")
        TextBox5.DataBindings.Add("text", BindingSource1, "calisilmayan_dakika")
        TextBox6.DataBindings.Add("text", BindingSource1, "calisilmayan_saniye")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer1.Enabled = False

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub SerialPort1_ErrorReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialErrorReceivedEventArgs) Handles SerialPort1.ErrorReceived
        Timer1.Stop()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BindingSource1.AddNew()
        TextBox2.Text = Date.Now.Date
        TextBox4.Text = "00"
        TextBox5.Text = "00"
        TextBox6.Text = "00"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BindingSource1.EndEdit()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BindingSource1.MoveFirst()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        BindingSource1.MovePrevious()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        BindingSource1.MoveLast()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        BindingSource1.RemoveAt(BindingSource1.Position)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        BindingSource1.CancelEdit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        saatler()
        dakikalar()
        maaslar()
        MsgBox(saat)
        MsgBox(dakika)
        MsgBox(maas)
        Dim carp As Double
        carp = 0
        carp = saat * 60
        carp = carp + dakika
        Dim ort As Double
        ort = 0
        ort = maas / carp
        MsgBox(ort)
        Dim genel As Double
        genel = 0
        genel = maas - ort
        TextBox8.Text = genel
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
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

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Select Case MessageBox.Show("Çıkmak İstiyormusunuz?", "Çıkış Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                Application.Exit()
            Case Else
                Me.Show()
        End Select
    End Sub

    Private Sub GeriDönToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeriDönToolStripMenuItem1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub İlişkiTabloAçToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles İlişkiTabloAçToolStripMenuItem.Click
        Form8.ShowDialog()

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            komut.CommandText = "insert into hesap (personel_no,tarih,calisilan_gun,calisilmayan_saat,calisilmayan_dakika,calisilmayan_saniye) values (  " & CInt(TextBox1.Text) & " , ' " & TextBox2.Text & " ' , " & CInt(TextBox3.Text) & " , " & CInt(TextBox4.Text) & " , " & CInt(TextBox5.Text) & " , " & CInt(TextBox6.Text) & " ) "
            komut.ExecuteNonQuery()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            MessageBox.Show("Kayıt Yapıldı..")
        Else
            MessageBox.Show("Lütfen Boşlukları Doldurunuz")
        End If
        baglan.Close()
    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        komut.CommandType = CommandType.Text
        If TextBox7.Text <> "" And TextBox8.Text Then
            komut.CommandText = "Update personel set cezali_maas = " & CInt(TextBox2.Text) & "  where personel_no= " & CInt(TextBox8.Text) & " "
            komut.ExecuteNonQuery()
            TextBox7.Clear()
            TextBox8.Clear()
            MessageBox.Show("Kayıt Yapıldı..")
            End
        Else
            MessageBox.Show("Lütfen Boşlukları Doldurunuz")
        End If
        baglan.Close()

    End Sub
End Class