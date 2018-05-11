<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ItemDESCLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Main))
        Me.combo_customer = New System.Windows.Forms.ComboBox()
        Me.CustomerDBTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockoutDBDataSet = New Stockout_App.stockoutDBDataSet()
        Me.CustomerDBTTableAdapter = New Stockout_App.stockoutDBDataSetTableAdapters.customerDBTTableAdapter()
        Me.combo_rep = New System.Windows.Forms.ComboBox()
        Me.RepDBTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepDBTTableAdapter = New Stockout_App.stockoutDBDataSetTableAdapters.repDBTTableAdapter()
        Me.combo_pn = New System.Windows.Forms.ComboBox()
        Me.ItemDBTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemDBTTableAdapter = New Stockout_App.stockoutDBDataSetTableAdapters.itemDBTTableAdapter()
        Me.TableAdapterManager = New Stockout_App.stockoutDBDataSetTableAdapters.TableAdapterManager()
        Me.text_description = New System.Windows.Forms.TextBox()
        Me.Pull_item_descToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Pull_item_descToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.text_reason = New System.Windows.Forms.TextBox()
        Me.text_needed = New System.Windows.Forms.TextBox()
        Me.text_available = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lab_pn = New System.Windows.Forms.Label()
        Me.lab_rep = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.check_alt = New System.Windows.Forms.CheckBox()
        Me.text_demand = New System.Windows.Forms.TextBox()
        Me.text_comment = New System.Windows.Forms.TextBox()
        Me.button_clear = New System.Windows.Forms.Button()
        Me.button_submit = New System.Windows.Forms.Button()
        Me.button_exit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        ItemDESCLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.CustomerDBTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockoutDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepDBTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDBTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pull_item_descToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ItemDESCLabel
        '
        ItemDESCLabel.AutoSize = True
        ItemDESCLabel.Location = New System.Drawing.Point(23, 49)
        ItemDESCLabel.Name = "ItemDESCLabel"
        ItemDESCLabel.Size = New System.Drawing.Size(90, 13)
        ItemDESCLabel.TabIndex = 3
        ItemDESCLabel.Text = "Item Description*:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(453, 98)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(94, 13)
        Label2.TabIndex = 12
        Label2.Text = "Needed Quantity*:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(116, 98)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(99, 13)
        Label3.TabIndex = 13
        Label3.Text = "Available Quantity*:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(16, 124)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(97, 13)
        Label4.TabIndex = 15
        Label4.Text = "Stockout Reason*:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(58, 22)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(54, 13)
        Label5.TabIndex = 16
        Label5.Text = "Customer:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(456, 23)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(90, 13)
        Label6.TabIndex = 14
        Label6.Text = "Monthly Demand:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(66, 308)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(59, 13)
        Label7.TabIndex = 16
        Label7.Text = "Comments:"
        '
        'combo_customer
        '
        Me.combo_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_customer.DataSource = Me.CustomerDBTBindingSource
        Me.combo_customer.DisplayMember = "customerName"
        Me.combo_customer.FormattingEnabled = True
        Me.combo_customer.Location = New System.Drawing.Point(118, 19)
        Me.combo_customer.Name = "combo_customer"
        Me.combo_customer.Size = New System.Drawing.Size(307, 21)
        Me.combo_customer.TabIndex = 7
        Me.combo_customer.ValueMember = "customerName"
        '
        'CustomerDBTBindingSource
        '
        Me.CustomerDBTBindingSource.DataMember = "customerDBT"
        Me.CustomerDBTBindingSource.DataSource = Me.StockoutDBDataSet
        '
        'StockoutDBDataSet
        '
        Me.StockoutDBDataSet.DataSetName = "stockoutDBDataSet"
        Me.StockoutDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDBTTableAdapter
        '
        Me.CustomerDBTTableAdapter.ClearBeforeFill = True
        '
        'combo_rep
        '
        Me.combo_rep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_rep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_rep.DataSource = Me.RepDBTBindingSource
        Me.combo_rep.DisplayMember = "repName"
        Me.combo_rep.FormattingEnabled = True
        Me.combo_rep.Location = New System.Drawing.Point(131, 26)
        Me.combo_rep.Name = "combo_rep"
        Me.combo_rep.Size = New System.Drawing.Size(121, 21)
        Me.combo_rep.TabIndex = 1
        Me.combo_rep.ValueMember = "repName"
        '
        'RepDBTBindingSource
        '
        Me.RepDBTBindingSource.DataMember = "repDBT"
        Me.RepDBTBindingSource.DataSource = Me.StockoutDBDataSet
        '
        'RepDBTTableAdapter
        '
        Me.RepDBTTableAdapter.ClearBeforeFill = True
        '
        'combo_pn
        '
        Me.combo_pn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combo_pn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_pn.DataSource = Me.ItemDBTBindingSource
        Me.combo_pn.DisplayMember = "itemPN"
        Me.combo_pn.FormattingEnabled = True
        Me.combo_pn.Location = New System.Drawing.Point(119, 19)
        Me.combo_pn.Name = "combo_pn"
        Me.combo_pn.Size = New System.Drawing.Size(248, 21)
        Me.combo_pn.TabIndex = 2
        Me.combo_pn.ValueMember = "itemPN"
        '
        'ItemDBTBindingSource
        '
        Me.ItemDBTBindingSource.DataMember = "itemDBT"
        Me.ItemDBTBindingSource.DataSource = Me.StockoutDBDataSet
        '
        'ItemDBTTableAdapter
        '
        Me.ItemDBTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerDBTTableAdapter = Me.CustomerDBTTableAdapter
        Me.TableAdapterManager.itemDBTTableAdapter = Me.ItemDBTTableAdapter
        Me.TableAdapterManager.repDBTTableAdapter = Me.RepDBTTableAdapter
        Me.TableAdapterManager.stockoutDBTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Stockout_App.stockoutDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'text_description
        '
        Me.text_description.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemDBTBindingSource, "itemDESC", True))
        Me.text_description.Location = New System.Drawing.Point(119, 46)
        Me.text_description.Multiline = True
        Me.text_description.Name = "text_description"
        Me.text_description.Size = New System.Drawing.Size(534, 42)
        Me.text_description.TabIndex = 3
        '
        'Pull_item_descToolStrip
        '
        Me.Pull_item_descToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.Pull_item_descToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Pull_item_descToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pull_item_descToolStripButton})
        Me.Pull_item_descToolStrip.Location = New System.Drawing.Point(9, 416)
        Me.Pull_item_descToolStrip.Name = "Pull_item_descToolStrip"
        Me.Pull_item_descToolStrip.Size = New System.Drawing.Size(102, 25)
        Me.Pull_item_descToolStrip.TabIndex = 5
        Me.Pull_item_descToolStrip.Text = "Pull_item_descToolStrip"
        Me.Pull_item_descToolStrip.Visible = False
        '
        'Pull_item_descToolStripButton
        '
        Me.Pull_item_descToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Pull_item_descToolStripButton.Name = "Pull_item_descToolStripButton"
        Me.Pull_item_descToolStripButton.Size = New System.Drawing.Size(89, 22)
        Me.Pull_item_descToolStripButton.Text = "pull_item_desc"
        Me.Pull_item_descToolStripButton.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.text_reason)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.text_needed)
        Me.GroupBox1.Controls.Add(Me.text_available)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lab_pn)
        Me.GroupBox1.Controls.Add(Me.combo_pn)
        Me.GroupBox1.Controls.Add(ItemDESCLabel)
        Me.GroupBox1.Controls.Add(Me.text_description)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 153)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'text_reason
        '
        Me.text_reason.Location = New System.Drawing.Point(119, 121)
        Me.text_reason.Name = "text_reason"
        Me.text_reason.Size = New System.Drawing.Size(534, 20)
        Me.text_reason.TabIndex = 6
        '
        'text_needed
        '
        Me.text_needed.Location = New System.Drawing.Point(553, 95)
        Me.text_needed.MaxLength = 9
        Me.text_needed.Name = "text_needed"
        Me.text_needed.ShortcutsEnabled = False
        Me.text_needed.Size = New System.Drawing.Size(100, 20)
        Me.text_needed.TabIndex = 5
        '
        'text_available
        '
        Me.text_available.Location = New System.Drawing.Point(221, 95)
        Me.text_available.MaxLength = 9
        Me.text_available.Name = "text_available"
        Me.text_available.ShortcutsEnabled = False
        Me.text_available.Size = New System.Drawing.Size(100, 20)
        Me.text_available.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "If you don't have a PN please select ""Not In Quickbooks"""
        '
        'lab_pn
        '
        Me.lab_pn.AutoSize = True
        Me.lab_pn.Location = New System.Drawing.Point(40, 22)
        Me.lab_pn.Name = "lab_pn"
        Me.lab_pn.Size = New System.Drawing.Size(73, 13)
        Me.lab_pn.TabIndex = 8
        Me.lab_pn.Text = "Part Number*:"
        '
        'lab_rep
        '
        Me.lab_rep.AutoSize = True
        Me.lab_rep.Location = New System.Drawing.Point(62, 29)
        Me.lab_rep.Name = "lab_rep"
        Me.lab_rep.Size = New System.Drawing.Size(63, 13)
        Me.lab_rep.TabIndex = 7
        Me.lab_rep.Text = "Sales Rep*:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.check_alt)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(Label5)
        Me.GroupBox2.Controls.Add(Me.text_demand)
        Me.GroupBox2.Controls.Add(Me.combo_customer)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 75)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'check_alt
        '
        Me.check_alt.AutoSize = True
        Me.check_alt.Location = New System.Drawing.Point(118, 46)
        Me.check_alt.Name = "check_alt"
        Me.check_alt.Size = New System.Drawing.Size(120, 17)
        Me.check_alt.TabIndex = 9
        Me.check_alt.Text = "Offered Alternative?"
        Me.check_alt.UseVisualStyleBackColor = True
        '
        'text_demand
        '
        Me.text_demand.Location = New System.Drawing.Point(552, 20)
        Me.text_demand.MaxLength = 9
        Me.text_demand.Name = "text_demand"
        Me.text_demand.ShortcutsEnabled = False
        Me.text_demand.Size = New System.Drawing.Size(100, 20)
        Me.text_demand.TabIndex = 8
        '
        'text_comment
        '
        Me.text_comment.Location = New System.Drawing.Point(131, 305)
        Me.text_comment.Multiline = True
        Me.text_comment.Name = "text_comment"
        Me.text_comment.Size = New System.Drawing.Size(534, 42)
        Me.text_comment.TabIndex = 10
        '
        'button_clear
        '
        Me.button_clear.Location = New System.Drawing.Point(590, 24)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(75, 23)
        Me.button_clear.TabIndex = 13
        Me.button_clear.Text = "Clear Form"
        Me.button_clear.UseVisualStyleBackColor = True
        '
        'button_submit
        '
        Me.button_submit.Location = New System.Drawing.Point(509, 376)
        Me.button_submit.Name = "button_submit"
        Me.button_submit.Size = New System.Drawing.Size(75, 23)
        Me.button_submit.TabIndex = 11
        Me.button_submit.Text = "SUBMIT"
        Me.button_submit.UseVisualStyleBackColor = True
        '
        'button_exit
        '
        Me.button_exit.Location = New System.Drawing.Point(590, 376)
        Me.button_exit.Name = "button_exit"
        Me.button_exit.Size = New System.Drawing.Size(75, 23)
        Me.button_exit.TabIndex = 12
        Me.button_exit.Text = "EXIT"
        Me.button_exit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "* Required Fields"
        '
        'form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 410)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.button_exit)
        Me.Controls.Add(Me.button_submit)
        Me.Controls.Add(Me.button_clear)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.text_comment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lab_rep)
        Me.Controls.Add(Me.Pull_item_descToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.combo_rep)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_Main"
        Me.Text = "AUGE Stockout App v1.0"
        CType(Me.CustomerDBTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockoutDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepDBTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDBTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pull_item_descToolStrip.ResumeLayout(False)
        Me.Pull_item_descToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_customer As ComboBox
    Friend WithEvents StockoutDBDataSet As stockoutDBDataSet
    Friend WithEvents CustomerDBTBindingSource As BindingSource
    Friend WithEvents CustomerDBTTableAdapter As stockoutDBDataSetTableAdapters.customerDBTTableAdapter
    Friend WithEvents combo_rep As ComboBox
    Friend WithEvents RepDBTBindingSource As BindingSource
    Friend WithEvents RepDBTTableAdapter As stockoutDBDataSetTableAdapters.repDBTTableAdapter
    Friend WithEvents combo_pn As ComboBox
    Friend WithEvents ItemDBTBindingSource As BindingSource
    Friend WithEvents ItemDBTTableAdapter As stockoutDBDataSetTableAdapters.itemDBTTableAdapter
    Friend WithEvents TableAdapterManager As stockoutDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents text_description As TextBox
    Friend WithEvents Pull_item_descToolStrip As ToolStrip
    Friend WithEvents Pull_item_descToolStripButton As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lab_pn As Label
    Friend WithEvents lab_rep As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents text_reason As TextBox
    Friend WithEvents text_needed As TextBox
    Friend WithEvents text_available As TextBox
    Friend WithEvents check_alt As CheckBox
    Friend WithEvents text_demand As TextBox
    Friend WithEvents text_comment As TextBox
    Friend WithEvents button_clear As Button
    Friend WithEvents button_submit As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents Label8 As Label
End Class
