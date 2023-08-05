<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        MenuStrip1 = New MenuStrip()
        BankingToolStripMenuItem = New ToolStripMenuItem()
        WithdrawsToolStripMenuItem = New ToolStripMenuItem()
        OtherToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BankingToolStripMenuItem, WithdrawsToolStripMenuItem, OtherToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BankingToolStripMenuItem
        ' 
        BankingToolStripMenuItem.Name = "BankingToolStripMenuItem"
        BankingToolStripMenuItem.Size = New Size(76, 24)
        BankingToolStripMenuItem.Text = "Banking"
        ' 
        ' WithdrawsToolStripMenuItem
        ' 
        WithdrawsToolStripMenuItem.Name = "WithdrawsToolStripMenuItem"
        WithdrawsToolStripMenuItem.Size = New Size(93, 24)
        WithdrawsToolStripMenuItem.Text = "Withdraws"
        ' 
        ' OtherToolStripMenuItem
        ' 
        OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        OtherToolStripMenuItem.Size = New Size(60, 24)
        OtherToolStripMenuItem.Text = "Other"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Finances"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BankingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WithdrawsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
End Class
