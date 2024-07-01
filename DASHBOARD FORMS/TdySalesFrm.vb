<Obsolete>
Public Class TdySalesFrm
    Private Sub TdySalesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.GridColor = Color.Teal
        DataGridView1.DefaultCellStyle.Font = New Font("Century Gothic", 8)
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 128)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        LoadInGridview()
    End Sub

    Private Sub LoadInGridview()
        Dim cn As OracleClient.OracleConnection = New OracleClient.OracleConnection("Data Source=localhost;Persist Security Info=True;User ID=SEPROJ;Password=seproj;Unicode=True")
        cn.Open()
        Dim command As New OracleClient.OracleCommand("Select INVOICE_NO, PRODUCT_CODE, DSCRTN AS DESCRIPTION, CATEGORY, PRICE, QUANTITY, TOTAL, USERS, STATUS, SOLD_DATE FROM TBLCART WHERE SOLD_DATE = trunc(sysdate)", cn)
        Dim sda As New OracleClient.OracleDataAdapter(command)
        Dim dt As New DataTable

        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class