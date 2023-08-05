<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        BachelorToolStripMenuItem = New ToolStripMenuItem()
        CWToolStripMenuItem = New ToolStripMenuItem()
        ExamsToolStripMenuItem = New ToolStripMenuItem()
        ProjectsToolStripMenuItem = New ToolStripMenuItem()
        OtherToolStripMenuItem1 = New ToolStripMenuItem()
        MastersToolStripMenuItem = New ToolStripMenuItem()
        ResearchToolStripMenuItem = New ToolStripMenuItem()
        PracticalToolStripMenuItem = New ToolStripMenuItem()
        SupervisorToolStripMenuItem = New ToolStripMenuItem()
        PhDToolStripMenuItem = New ToolStripMenuItem()
        ThesiToolStripMenuItem = New ToolStripMenuItem()
        SupervisionToolStripMenuItem = New ToolStripMenuItem()
        OtherToolStripMenuItem = New ToolStripMenuItem()
        CertificateToolStripMenuItem = New ToolStripMenuItem()
        DiplomaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {BachelorToolStripMenuItem, MastersToolStripMenuItem, PhDToolStripMenuItem, OtherToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BachelorToolStripMenuItem
        ' 
        BachelorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CWToolStripMenuItem, ExamsToolStripMenuItem, ProjectsToolStripMenuItem, OtherToolStripMenuItem1})
        BachelorToolStripMenuItem.Name = "BachelorToolStripMenuItem"
        BachelorToolStripMenuItem.Size = New Size(81, 24)
        BachelorToolStripMenuItem.Text = "Bachelor"
        ' 
        ' CWToolStripMenuItem
        ' 
        CWToolStripMenuItem.Name = "CWToolStripMenuItem"
        CWToolStripMenuItem.Size = New Size(144, 26)
        CWToolStripMenuItem.Text = "CW"
        ' 
        ' ExamsToolStripMenuItem
        ' 
        ExamsToolStripMenuItem.Name = "ExamsToolStripMenuItem"
        ExamsToolStripMenuItem.Size = New Size(144, 26)
        ExamsToolStripMenuItem.Text = "Exams"
        ' 
        ' ProjectsToolStripMenuItem
        ' 
        ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        ProjectsToolStripMenuItem.Size = New Size(144, 26)
        ProjectsToolStripMenuItem.Text = "Projects"
        ' 
        ' OtherToolStripMenuItem1
        ' 
        OtherToolStripMenuItem1.Name = "OtherToolStripMenuItem1"
        OtherToolStripMenuItem1.Size = New Size(144, 26)
        OtherToolStripMenuItem1.Text = "Other"
        ' 
        ' MastersToolStripMenuItem
        ' 
        MastersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ResearchToolStripMenuItem, PracticalToolStripMenuItem, SupervisorToolStripMenuItem})
        MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        MastersToolStripMenuItem.Size = New Size(74, 24)
        MastersToolStripMenuItem.Text = "Masters"
        ' 
        ' ResearchToolStripMenuItem
        ' 
        ResearchToolStripMenuItem.Name = "ResearchToolStripMenuItem"
        ResearchToolStripMenuItem.Size = New Size(161, 26)
        ResearchToolStripMenuItem.Text = "Research"
        ' 
        ' PracticalToolStripMenuItem
        ' 
        PracticalToolStripMenuItem.Name = "PracticalToolStripMenuItem"
        PracticalToolStripMenuItem.Size = New Size(161, 26)
        PracticalToolStripMenuItem.Text = "Practical"
        ' 
        ' SupervisorToolStripMenuItem
        ' 
        SupervisorToolStripMenuItem.Name = "SupervisorToolStripMenuItem"
        SupervisorToolStripMenuItem.Size = New Size(161, 26)
        SupervisorToolStripMenuItem.Text = "Supervisor"
        ' 
        ' PhDToolStripMenuItem
        ' 
        PhDToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ThesiToolStripMenuItem, SupervisionToolStripMenuItem})
        PhDToolStripMenuItem.Name = "PhDToolStripMenuItem"
        PhDToolStripMenuItem.Size = New Size(50, 24)
        PhDToolStripMenuItem.Text = "PhD"
        ' 
        ' ThesiToolStripMenuItem
        ' 
        ThesiToolStripMenuItem.Name = "ThesiToolStripMenuItem"
        ThesiToolStripMenuItem.Size = New Size(168, 26)
        ThesiToolStripMenuItem.Text = "Thesis"
        ' 
        ' SupervisionToolStripMenuItem
        ' 
        SupervisionToolStripMenuItem.Name = "SupervisionToolStripMenuItem"
        SupervisionToolStripMenuItem.Size = New Size(168, 26)
        SupervisionToolStripMenuItem.Text = "Supervision"
        ' 
        ' OtherToolStripMenuItem
        ' 
        OtherToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CertificateToolStripMenuItem, DiplomaToolStripMenuItem})
        OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        OtherToolStripMenuItem.Size = New Size(60, 24)
        OtherToolStripMenuItem.Text = "Other"
        ' 
        ' CertificateToolStripMenuItem
        ' 
        CertificateToolStripMenuItem.Name = "CertificateToolStripMenuItem"
        CertificateToolStripMenuItem.Size = New Size(224, 26)
        CertificateToolStripMenuItem.Text = "Certificate"
        ' 
        ' DiplomaToolStripMenuItem
        ' 
        DiplomaToolStripMenuItem.Name = "DiplomaToolStripMenuItem"
        DiplomaToolStripMenuItem.Size = New Size(224, 26)
        DiplomaToolStripMenuItem.Text = "Diploma"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Academics"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BachelorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MastersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PracticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupervisorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThesiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupervisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiplomaToolStripMenuItem As ToolStripMenuItem
End Class
