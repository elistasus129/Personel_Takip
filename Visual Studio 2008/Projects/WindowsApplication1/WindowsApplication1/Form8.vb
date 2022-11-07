Imports System.Data.OleDb
Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim baglan As New OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0 ; Data Source=proje.accdb")
        Dim adap As New OleDbDataAdapter
        Dim ds As New DataSet

        adap = New OleDb.OleDbDataAdapter("select * from personel", baglan)
        adap.fill(ds, "tablo1")
        adap = New OleDb.OleDbDataAdapter("select * from hesap", baglan)
        adap.fill(ds, "tablo2")

        Dim anatablo As DataColumn
        Dim yavrutablo As DataColumn

        anatablo = ds.Tables("tablo1").Columns("personel_no")
        yavrutablo = ds.Tables("tablo2").Columns("personel_no")

        Dim iliski As New DataRelation("Per", anatablo, yavrutablo)
        ds.Relations.Add(iliski)
        DataGrid1.DataSource = ds.Tables("tablo1")

    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class