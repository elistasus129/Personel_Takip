Imports System.Data.OleDb
Public Class Form7

    Dim kaynak As String = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=proje.accdb"

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        Dim komut As New OleDbCommand
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        komut.CommandText = ("Update personel set tc_no =   " & CInt(TextBox2.Text) & "  , adi = ' " & TextBox3.Text & " ' , soyadi = ' " & TextBox4.Text & " ' , cinsiyet = ' " & TextBox5.Text & " ', departman = ' " & TextBox6.Text & " ' , genel_maas = " & CInt(TextBox7.Text) & "  , cezali_maas =  " & CInt(TextBox8.Text) & "   where  personel_no =   " & CInt(TextBox1.Text) & "  ")
        komut.ExecuteNonQuery()
        baglan.Close()
        DataGridView1.Refresh()

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

    

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
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

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim adap As New OleDbDataAdapter("select * from musteri where adi like'%" & TextBox9.Text & "%'", baglan)
        Dim tablo As New DataTable
        adap.Fill(tablo)
        Dim data As New DataSet
        data.Tables.Add(tablo)
        BindingSource1.DataSource = data.Tables(0)
        DataGridView1.DataSource = BindingSource1
        baglan.Close()
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
End Class