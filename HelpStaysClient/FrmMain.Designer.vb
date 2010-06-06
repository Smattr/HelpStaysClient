<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReserve = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplyFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstMain = New System.Windows.Forms.ListView
        Me.colID = New System.Windows.Forms.ColumnHeader
        Me.colOwner = New System.Windows.Forms.ColumnHeader
        Me.colPhoneNumber = New System.Windows.Forms.ColumnHeader
        Me.colAddress = New System.Windows.Forms.ColumnHeader
        Me.sstMain = New System.Windows.Forms.StatusStrip
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.bgwRefresh = New System.ComponentModel.BackgroundWorker
        Me.tsbRefresh = New System.Windows.Forms.ToolStripSplitButton
        Me.tsbDefaultCount = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMain.SuspendLayout()
        Me.sstMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(669, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReserve, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuReserve
        '
        Me.mnuReserve.Enabled = False
        Me.mnuReserve.Name = "mnuReserve"
        Me.mnuReserve.Size = New System.Drawing.Size(152, 22)
        Me.mnuReserve.Text = "Reserve Bed"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplyFilterToolStripMenuItem, Me.RemToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.tsbDefaultCount})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(41, 20)
        Me.mnuView.Text = "&View"
        '
        'ApplyFilterToolStripMenuItem
        '
        Me.ApplyFilterToolStripMenuItem.Name = "ApplyFilterToolStripMenuItem"
        Me.ApplyFilterToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ApplyFilterToolStripMenuItem.Text = "Apply &Filter..."
        '
        'RemToolStripMenuItem
        '
        Me.RemToolStripMenuItem.Name = "RemToolStripMenuItem"
        Me.RemToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RemToolStripMenuItem.Text = "&Remove Filter"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'lstMain
        '
        Me.lstMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colOwner, Me.colPhoneNumber, Me.colAddress})
        Me.lstMain.FullRowSelect = True
        Me.lstMain.Location = New System.Drawing.Point(0, 27)
        Me.lstMain.MultiSelect = False
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(669, 346)
        Me.lstMain.TabIndex = 1
        Me.lstMain.UseCompatibleStateImageBehavior = False
        Me.lstMain.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.DisplayIndex = 3
        Me.colID.Text = "ID"
        Me.colID.Width = 0
        '
        'colOwner
        '
        Me.colOwner.DisplayIndex = 0
        Me.colOwner.Text = "Owner"
        Me.colOwner.Width = 120
        '
        'colPhoneNumber
        '
        Me.colPhoneNumber.DisplayIndex = 1
        Me.colPhoneNumber.Text = "Phone Number"
        Me.colPhoneNumber.Width = 120
        '
        'colAddress
        '
        Me.colAddress.DisplayIndex = 2
        Me.colAddress.Text = "Address"
        Me.colAddress.Width = 300
        '
        'sstMain
        '
        Me.sstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefresh, Me.lblStatus})
        Me.sstMain.Location = New System.Drawing.Point(0, 376)
        Me.sstMain.Name = "sstMain"
        Me.sstMain.Size = New System.Drawing.Size(669, 22)
        Me.sstMain.TabIndex = 2
        Me.sstMain.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bgwRefresh
        '
        Me.bgwRefresh.WorkerReportsProgress = True
        Me.bgwRefresh.WorkerSupportsCancellation = True
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.DropDownButtonWidth = 0
        Me.tsbRefresh.Image = Global.HelpStaysClient.My.Resources.Resources.refresh
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(21, 20)
        Me.tsbRefresh.Text = "Refresh"
        '
        'tsbDefaultCount
        '
        Me.tsbDefaultCount.Name = "tsbDefaultCount"
        Me.tsbDefaultCount.Size = New System.Drawing.Size(204, 22)
        Me.tsbDefaultCount.Text = "Set Default Result Count"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 398)
        Me.Controls.Add(Me.sstMain)
        Me.Controls.Add(Me.lstMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HelpStays"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.sstMain.ResumeLayout(False)
        Me.sstMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents lstMain As System.Windows.Forms.ListView
    Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
    Friend WithEvents colOwner As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPhoneNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents bgwRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents mnuReserve As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsbDefaultCount As System.Windows.Forms.ToolStripMenuItem

End Class
