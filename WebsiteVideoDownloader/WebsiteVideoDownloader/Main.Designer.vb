<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btClean = New System.Windows.Forms.Button()
        Me.lbWebSiteURL = New System.Windows.Forms.Label()
        Me.tbWebsiteURL = New System.Windows.Forms.TextBox()
        Me.functionTab = New System.Windows.Forms.TabControl()
        Me.manageTabPage = New System.Windows.Forms.TabPage()
        Me.parseProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lbVideoLink = New System.Windows.Forms.Label()
        Me.btDownVideo = New System.Windows.Forms.Button()
        Me.btParseURL = New System.Windows.Forms.Button()
        Me.tbVideoLink = New System.Windows.Forms.TextBox()
        Me.tasksTabPage = New System.Windows.Forms.TabPage()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.prgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.functionTab.SuspendLayout()
        Me.manageTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btClean
        '
        Me.btClean.Location = New System.Drawing.Point(145, 175)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(80, 32)
        Me.btClean.TabIndex = 3
        Me.btClean.Text = "清空信息"
        Me.btClean.UseVisualStyleBackColor = True
        '
        'lbWebSiteURL
        '
        Me.lbWebSiteURL.AutoSize = True
        Me.lbWebSiteURL.Location = New System.Drawing.Point(6, 9)
        Me.lbWebSiteURL.Name = "lbWebSiteURL"
        Me.lbWebSiteURL.Size = New System.Drawing.Size(65, 12)
        Me.lbWebSiteURL.TabIndex = 1
        Me.lbWebSiteURL.Text = "视频网址："
        '
        'tbWebsiteURL
        '
        Me.tbWebsiteURL.Location = New System.Drawing.Point(77, 6)
        Me.tbWebsiteURL.Multiline = True
        Me.tbWebsiteURL.Name = "tbWebsiteURL"
        Me.tbWebsiteURL.Size = New System.Drawing.Size(320, 42)
        Me.tbWebsiteURL.TabIndex = 1
        '
        'functionTab
        '
        Me.functionTab.Controls.Add(Me.manageTabPage)
        Me.functionTab.Controls.Add(Me.tasksTabPage)
        Me.functionTab.Location = New System.Drawing.Point(12, 12)
        Me.functionTab.Multiline = True
        Me.functionTab.Name = "functionTab"
        Me.functionTab.SelectedIndex = 0
        Me.functionTab.Size = New System.Drawing.Size(411, 280)
        Me.functionTab.TabIndex = 0
        '
        'manageTabPage
        '
        Me.manageTabPage.Controls.Add(Me.parseProgressBar)
        Me.manageTabPage.Controls.Add(Me.lbVideoLink)
        Me.manageTabPage.Controls.Add(Me.lbWebSiteURL)
        Me.manageTabPage.Controls.Add(Me.btDownVideo)
        Me.manageTabPage.Controls.Add(Me.btParseURL)
        Me.manageTabPage.Controls.Add(Me.btClean)
        Me.manageTabPage.Controls.Add(Me.tbVideoLink)
        Me.manageTabPage.Controls.Add(Me.tbWebsiteURL)
        Me.manageTabPage.Location = New System.Drawing.Point(4, 22)
        Me.manageTabPage.Name = "manageTabPage"
        Me.manageTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.manageTabPage.Size = New System.Drawing.Size(403, 254)
        Me.manageTabPage.TabIndex = 0
        Me.manageTabPage.Text = "任务管理"
        Me.manageTabPage.UseVisualStyleBackColor = True
        '
        'parseProgressBar
        '
        Me.parseProgressBar.Location = New System.Drawing.Point(6, 181)
        Me.parseProgressBar.Name = "parseProgressBar"
        Me.parseProgressBar.Size = New System.Drawing.Size(128, 20)
        Me.parseProgressBar.TabIndex = 6
        '
        'lbVideoLink
        '
        Me.lbVideoLink.AutoSize = True
        Me.lbVideoLink.Location = New System.Drawing.Point(6, 57)
        Me.lbVideoLink.Name = "lbVideoLink"
        Me.lbVideoLink.Size = New System.Drawing.Size(65, 12)
        Me.lbVideoLink.TabIndex = 1
        Me.lbVideoLink.Text = "视频链接："
        '
        'btDownVideo
        '
        Me.btDownVideo.Location = New System.Drawing.Point(317, 175)
        Me.btDownVideo.Name = "btDownVideo"
        Me.btDownVideo.Size = New System.Drawing.Size(80, 32)
        Me.btDownVideo.TabIndex = 5
        Me.btDownVideo.Text = "下载视频"
        Me.btDownVideo.UseVisualStyleBackColor = True
        '
        'btParseURL
        '
        Me.btParseURL.Location = New System.Drawing.Point(231, 175)
        Me.btParseURL.Name = "btParseURL"
        Me.btParseURL.Size = New System.Drawing.Size(80, 32)
        Me.btParseURL.TabIndex = 4
        Me.btParseURL.Text = "解析链接"
        Me.btParseURL.UseVisualStyleBackColor = True
        '
        'tbVideoLink
        '
        Me.tbVideoLink.Location = New System.Drawing.Point(77, 54)
        Me.tbVideoLink.Multiline = True
        Me.tbVideoLink.Name = "tbVideoLink"
        Me.tbVideoLink.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbVideoLink.Size = New System.Drawing.Size(320, 100)
        Me.tbVideoLink.TabIndex = 2
        '
        'tasksTabPage
        '
        Me.tasksTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tasksTabPage.Name = "tasksTabPage"
        Me.tasksTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tasksTabPage.Size = New System.Drawing.Size(403, 254)
        Me.tasksTabPage.TabIndex = 1
        Me.tasksTabPage.Text = "下载队列"
        Me.tasksTabPage.UseVisualStyleBackColor = True
        '
        'bgWorker
        '
        '
        'prgTimer
        '
        Me.prgTimer.Interval = 500
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 304)
        Me.Controls.Add(Me.functionTab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website Video Downloader"
        Me.functionTab.ResumeLayout(False)
        Me.manageTabPage.ResumeLayout(False)
        Me.manageTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btClean As Button
    Friend WithEvents lbWebSiteURL As Label
    Friend WithEvents tbWebsiteURL As TextBox
    Friend WithEvents functionTab As TabControl
    Friend WithEvents manageTabPage As TabPage
    Friend WithEvents lbVideoLink As Label
    Friend WithEvents btDownVideo As Button
    Friend WithEvents btParseURL As Button
    Friend WithEvents tbVideoLink As TextBox
    Friend WithEvents tasksTabPage As TabPage
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents prgTimer As Timer
    Friend WithEvents parseProgressBar As ProgressBar
End Class
