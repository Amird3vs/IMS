Imports MySql.Data.MySqlClient

<Obsolete>
Public Class Dashboard

    Dim ql As String
    Dim cmd As MySqlCommand
    Dim cn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As DataSet
    Dim dt As DataTable

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'CritPRDCTS.PRDCTS' table. You can move, or remove it, as needed.
        'Me.PRDCTSTableAdapter1.Fill(Me.CritPRDCTS.PRDCTS)
        ''TODO: This line of code loads data into the 'DataSet1.PRDCTS' table. You can move, or remove it, as needed.
        'Me.PRDCTSTableAdapter.Fill(Me.DataSet1.PRDCTS)
        ''TODO: This line of code loads data into the 'DataSet1.PRDCTS' table. You can move, or remove it, as needed.
        'Me.PRDCTSTableAdapter.Fill(Me.DataSet1.PRDCTS)

        crit()
        DashBoard()
    End Sub

    Public Function GetTotal(ByVal sql As String) As Double
        'Dim cn As MySqlConnection = New MySqlConnection("server=localhost;database=test;uid=root;pwd=;")
        'Dim _total As Double = 0
        'Try
        '    cn.Open()
        '    Dim cmd As New MySqlCommand(sql, cn)
        '    _total = Double.Parse(cmd.ExecuteScalar().ToString())
        'Catch ex As Exception
        '    cn.Close()
        '    MsgBox(ex.Message)
        'End Try
        'Return _total
    End Function

    Public Sub DashBoard()
        'LblDSales.Text = GetTotal("Select COALESCE(SUM(TOTAL),0) FROM TBLCART WHERE SOLD_DATE = trunc(sysdate)").ToString("₱#,##0.00")
        'lblWSales.Text = GetTotal("Select COALESCE(SUM(TOTAL),0) FROM TBLCART WHERE SOLD_DATE BETWEEN trunc(sysdate - 7) and trunc(sysdate)").ToString("₱#,##0.00")
        'lblMSales.Text = GetTotal("Select COALESCE(SUM(TOTAL),0) FROM TBLCART WHERE SOLD_DATE BETWEEN trunc(sysdate-30) AND trunc(sysdate)").ToString("₱#,##0.00")
    End Sub


    Public Sub crit()
        'Dim cn As MySqlConnection = New MySqlConnection("server=localhost;database=test;uid=root;pwd=;")
        'cn.Open()
        'Try
        '    Dim row As String
        '    ql = "SELECT COALESCE(COUNT(PRODUCT_CODE),0) AS PRODUCT_CODE FROM PRDCTS WHERE QUANTITY <= REORDER"
        '    cmd = New MySqlCommand(ql, cn)
        '    row = cmd.ExecuteScalar()

        '    lblSlow.Text = row

        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'Finally
        '    cn.Close()
        'End Try
    End Sub

    Public Sub critical()
        'Dim cn As MySqlConnection = New MySqlConnection("server=localhost;database=test;uid=root;pwd=;")
        'cn.Open()
        'Try
        '    ql = "SELECT * FROM PRDCTS WHERE QUANTITY <= REORDER"
        '    cmd = New MySqlCommand(ql, cn)
        '    Dim dr As MySqlDataReader
        '    dr = cmd.ExecuteReader()
        '    dr.Read()

        '    If dr.HasRows = True Then
        '        Do While dr.Read()
        '            Me.Alert(dr("PRODUCT_CODE") + " " + "is low in stock", Form_Alert.enmType.Info)
        '        Loop
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'Finally
        '    cn.Close()
        'End Try
    End Sub

    Private Sub btnUICust_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = ColorDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.No Then
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.OK Then
            Chart1.BackColor = ColorDialog1.Color
            Guna2GradientPanel1.FillColor = ColorDialog1.Color
            Guna2GradientPanel2.FillColor = ColorDialog1.Color
            Guna2GradientPanel3.FillColor = ColorDialog1.Color
            Guna2GradientPanel4.FillColor = ColorDialog1.Color
            Label14.ForeColor = ColorDialog1.Color
            Label15.ForeColor = ColorDialog1.Color
            Guna2Panel2.BackColor = ColorDialog1.Color
        End If
    End Sub

    Public Sub Alert(ByVal msg As String, ByVal type As Form_Alert.enmType)
        Dim frm As Form_Alert = New Form_Alert()
        frm.showAlert(msg, type)
    End Sub

    Private Sub Dashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        critical()
    End Sub

    Private Sub Guna2GradientPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel1.MouseClick
        TdySalesFrm.ShowDialog()
    End Sub

    Private Sub Guna2GradientPanel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel2.MouseClick
        WklySalesFrm.ShowDialog()
    End Sub

    Private Sub Guna2GradientPanel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel3.MouseClick
        MnthlySalesFrm.ShowDialog()
    End Sub

    Private Sub Guna2GradientPanel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel4.MouseClick
        critprddcts.ShowDialog()
    End Sub
End Class