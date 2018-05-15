Imports System.Net.Mail

Public Class form_Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockoutDBDataSet.itemDBT' table. You can move, or remove it, as needed.
        Me.ItemDBTTableAdapter.Fill(Me.StockoutDBDataSet.itemDBT)
        'TODO: This line of code loads data into the 'StockoutDBDataSet.repDBT' table. You can move, or remove it, as needed.
        Me.RepDBTTableAdapter.Fill(Me.StockoutDBDataSet.repDBT)
        'TODO: This line of code loads data into the 'StockoutDBDataSet.customerDBT' table. You can move, or remove it, as needed.
        Me.CustomerDBTTableAdapter.Fill(Me.StockoutDBDataSet.customerDBT)

        'initialize with text in dropdowns cleared of values
        'combo_rep.Text = ""
        'combo_pn.Text = ""
        'combo_customer.Text = ""
        text_description.Text = ""
        combo_rep.SelectedIndex = -1
        combo_pn.SelectedIndex = -1
        combo_customer.SelectedIndex = -1

    End Sub

    Private Sub Pull_item_descToolStripButton_Click(sender As Object, e As EventArgs) Handles Pull_item_descToolStripButton.Click
        Try
            Me.ItemDBTTableAdapter.pull_item_desc(Me.StockoutDBDataSet.itemDBT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Clear_form()
        'set all fields to defaut values
        combo_rep.SelectedIndex = -1
        combo_pn.SelectedIndex = -1
        combo_customer.SelectedIndex = -1
        text_available.Text = ""
        text_comment.Text = ""
        text_demand.Text = ""
        text_description.Text = ""
        text_needed.Text = ""
        text_reason.Text = ""
        check_alt.Checked = False
    End Sub

    Sub Send_Email_Notification()

        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_query_smtp_Host As New OleDb.OleDbCommand
        Dim sql_query_smtp_User As New OleDb.OleDbCommand
        Dim sql_query_smtp_Pass As New OleDb.OleDbCommand
        Dim sql_query_smtp_From As New OleDb.OleDbCommand
        Dim sql_query_smtp_To As New OleDb.OleDbCommand

        Dim smtp_Host As String
        Dim smtp_User As String
        Dim smtp_Pass As String
        Dim smtp_From As String
        Dim smtp_To As String

        Dim conn_string As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Inventory Center\StockOut App\db\stockoutDB.accdb"
        sql_conn.ConnectionString = conn_string
        sql_query_smtp_Host.Connection = sql_conn
        sql_query_smtp_User.Connection = sql_conn
        sql_query_smtp_Pass.Connection = sql_conn
        sql_query_smtp_From.Connection = sql_conn
        sql_query_smtp_To.Connection = sql_conn

        sql_query_smtp_Host.CommandText = "SELECT smtp_Host FROM smtpDBT WHERE smtp_Main = @Main"
        sql_query_smtp_User.CommandText = "SELECT smtp_User FROM smtpDBT WHERE smtp_Main = @Main"
        sql_query_smtp_Pass.CommandText = "SELECT smtp_Pass FROM smtpDBT WHERE smtp_Main = @Main"
        sql_query_smtp_From.CommandText = "SELECT smtp_From FROM smtpDBT WHERE smtp_Main = @Main"
        sql_query_smtp_To.CommandText = "SELECT smtp_To FROM smtpDBT WHERE smtp_Main = @Main"

        sql_query_smtp_Host.Parameters.AddWithValue("@Main", "MAIN")
        sql_query_smtp_User.Parameters.AddWithValue("@Main", "MAIN")
        sql_query_smtp_Pass.Parameters.AddWithValue("@Main", "MAIN")
        sql_query_smtp_From.Parameters.AddWithValue("@Main", "MAIN")
        sql_query_smtp_To.Parameters.AddWithValue("@Main", "MAIN")

        Try
            sql_conn.Open()
            smtp_Host = Convert.ToString(sql_query_smtp_Host.ExecuteScalar())
            smtp_User = Convert.ToString(sql_query_smtp_User.ExecuteScalar())
            smtp_Pass = Convert.ToString(sql_query_smtp_Pass.ExecuteScalar())
            smtp_From = Convert.ToString(sql_query_smtp_From.ExecuteScalar())
            smtp_To = Convert.ToString(sql_query_smtp_To.ExecuteScalar())

            MsgBox(smtp_Host & " " & smtp_User & " " & smtp_Pass & " " & smtp_From & " " & smtp_To)
            sql_conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(smtp_User, smtp_Pass)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = smtp_Host

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(smtp_From)
            e_mail.To.Add(smtp_To)
            e_mail.Subject = "New Stockout Notification"
            e_mail.IsBodyHtml = False
            e_mail.Body = combo_rep.Text & " has just reported a new stockout."
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox("Could not send email: " & error_t.ToString)
        End Try
    End Sub

    Private Sub button_submit_Click(sender As Object, e As EventArgs) Handles button_submit.Click
        'submit button

        'define vars
        Dim sql_conn As New OleDb.OleDbConnection
        Dim sql_query As New OleDb.OleDbCommand
        Dim conn_string As String

        'define SQL connection
        conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Inventory Center\StockOut App\db\stockoutDB.accdb"
        sql_conn.ConnectionString = conn_string
        sql_query.Connection = sql_conn

        'validate data
        If combo_rep.Text = "" Then
            'combo_rep.BackColor = ColorTranslator.FromHtml("#FF0000")
            MsgBox("Please select Sales Rep")
            Exit Sub
            'Else
            'combo_rep.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        End If
        If combo_pn.Text = "" Then
            MsgBox("Please select a Part Number")
            Exit Sub
        End If
        If text_description.Text = "" Then
            MsgBox("Please fill out the Item Description")
            Exit Sub
        End If
        If text_available.Text = "" Then
            MsgBox("Please fill out the Available Quantity")
            Exit Sub
        End If
        If text_needed.Text = "" Then
            MsgBox("Please fill out the Needed Quantity")
            Exit Sub
        End If
        If text_reason.Text = "" Then
            MsgBox("Please fill out the Stockout Reason")
            Exit Sub
        End If
        If text_demand.Text = "" Then
            text_demand.Text = 0
            Exit Sub
        End If

        'generate Query
        sql_query.CommandText = "INSERT INTO stockoutDBT([REP],[NOTIFICATION_DATE],[QB_PN],[QB_DESCRIPTION],[QTY_AVAILABLE],[QTY_NEEDED],[RELATED_CUSTOMER],[AVG_MO_DEMAND],[WHY_STOCKOUT_WAS_IDENTIFIED],[WAS_ALT_OFFERED],[COMMENTS_OTHER])VALUES(@REP,@DATE,@PN,@DESC,@QTYA,@QTYN,@CUST,@DEMAND,@WHY,@ALT,@COMMENTS)"
        sql_query.Parameters.AddWithValue("@REP", combo_rep.Text)
        sql_query.Parameters.AddWithValue("@DATE", Date.Today)
        sql_query.Parameters.AddWithValue("@PN", combo_pn.Text)
        sql_query.Parameters.AddWithValue("@DESC", text_description.Text)
        sql_query.Parameters.AddWithValue("@QTYA", text_available.Text)
        sql_query.Parameters.AddWithValue("@QTYN", text_needed.Text)
        sql_query.Parameters.AddWithValue("@CUST", combo_customer.Text)
        sql_query.Parameters.AddWithValue("@DEMAND", text_demand.Text)
        sql_query.Parameters.AddWithValue("@WHY", text_reason.Text)
        sql_query.Parameters.AddWithValue("@ALT", check_alt.Checked)
        sql_query.Parameters.AddWithValue("@COMMENTS", text_comment.Text)


        'execute Query - sql insert into access db
        Try
            sql_conn.Open()
            sql_query.ExecuteNonQuery()
            Send_Email_Notification()
            MsgBox("Your stockout notice has been submitted! Thank You!")
            sql_conn.Close()
            Clear_form()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub button_clear_Click(sender As Object, e As EventArgs) Handles button_clear.Click
        'clear form button
        Clear_form()
    End Sub
    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        'exit button
        End
    End Sub

    'Validate data fields below
    Private Sub text_available_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_available.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub text_demand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_demand.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub text_needed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_needed.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub combo_pn_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_pn.SelectedValueChanged
        If combo_pn.Text = "Not In Quickbooks" Then
            text_description.Enabled = True
        Else
            text_description.Enabled = False
        End If
    End Sub

End Class
