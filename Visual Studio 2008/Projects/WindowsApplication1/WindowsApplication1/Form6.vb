Imports System.Data.OleDb

Public Class Form6
    Dim kaynak As String = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source = proje.accdb "
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim baglan As New OleDbConnection(kaynak)
        Dim adap As New OleDbDataAdapter("select * from personel", baglan)
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
        komut.CommandText = "delete from personel where personel_no = " & CInt(TextBox1.Text) & "   "
        BindingSource1.RemoveCurrent()
        komut.ExecuteNonQuery()
        MsgBox("Kayıt Silindi")
        baglan.Close()
        DataGridView1.Refresh()
        Dim adap As New OleDbDataAdapter("select * from personel", baglan)
        Dim tablo As New DataTable()
        Dim ds As New DataSet()
        adap.Fill(ds, "tablo")
        ds.Tables.Add(tablo)
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = ds.Tables(0).TableName
        DataGridView1.DataSource = BindingSource1

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        Dim yol As String = Application.StartupPath.ToString()
        Dim baglan As New OleDbConnection(kaynak)
        Dim komut As New OleDbCommand
        baglan.Open()
        komut.Connection = baglan
        komut.CommandType = CommandType.Text
        komut.CommandText = "delete from personel where personel_no = " & CInt(TextBox1.Text) & "   "
        BindingSource1.RemoveCurrent()
        komut.ExecuteNonQuery()
        MsgBox("Kayıt Silindi")
        baglan.Close()
        DataGridView1.Refresh()
        Dim adap As New OleDbDataAdapter("select * from personel", baglan)
        Dim tablo As New DataTable()
        Dim ds As New DataSet()
        adap.Fill(ds, "tablo")
        ds.Tables.Add(tablo)
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = ds.Tables(0).TableName
        DataGridView1.DataSource = BindingSource1
    End Sub



    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim baglan As New OleDbConnection(kaynak)
        baglan.Open()
        Dim adap As New OleDbDataAdapter("select * from personel where adi like'%" & TextBox2.Text & "%'", baglan)
        Dim tablo As New DataTable
        adap.Fill(tablo)
        Dim data As New DataSet
        data.Tables.Add(tablo)
        BindingSource1.DataSource = data.Tables(0)
        DataGridView1.DataSource = BindingSource1
        baglan.Close()
    End Sub
End Class