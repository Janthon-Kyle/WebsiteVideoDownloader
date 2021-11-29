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
        Me.lbProxyAddr = New System.Windows.Forms.Label()
        Me.lbProxyPort = New System.Windows.Forms.Label()
        Me.tbProxyPort = New System.Windows.Forms.TextBox()
        Me.tbProxyAddr = New System.Windows.Forms.TextBox()
        Me.chkbProxy = New System.Windows.Forms.CheckBox()
        Me.parseProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lbVideoLink = New System.Windows.Forms.Label()
        Me.btDownVideo = New System.Windows.Forms.Button()
        Me.btParseURL = New System.Windows.Forms.Button()
        Me.tbVideoLink = New System.Windows.Forms.TextBox()
        Me.tasksTabPage = New System.Windows.Forms.TabPage()
        Me.lbDownProg = New System.Windows.Forms.Label()
        Me.btSavePath = New System.Windows.Forms.Button()
        Me.prgbarDownload = New System.Windows.Forms.ProgressBar()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.prgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.downprgTimer = New System.Windows.Forms.Timer(Me.components)
        Me.saveFDVideo = New System.Windows.Forms.SaveFileDialog()
        Me.resetStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.functionTab.SuspendLayout()
        Me.manageTabPage.SuspendLayout()
        Me.tasksTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btClean
        '
        Me.btClean.Location = New System.Drawing.Point(172, 222)
        Me.btClean.Margin = New System.Windows.Forms.Padding(4)
        Me.btClean.Name = "btClean"
        Me.btClean.Size = New System.Drawing.Size(92, 38)
        Me.btClean.TabIndex = 3
        Me.btClean.Text = "清空信息"
        Me.btClean.UseVisualStyleBackColor = True
        '
        'lbWebSiteURL
        '
        Me.lbWebSiteURL.AutoSize = True
        Me.lbWebSiteURL.Location = New System.Drawing.Point(8, 11)
        Me.lbWebSiteURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbWebSiteURL.Name = "lbWebSiteURL"
        Me.lbWebSiteURL.Size = New System.Drawing.Size(68, 17)
        Me.lbWebSiteURL.TabIndex = 1
        Me.lbWebSiteURL.Text = "视频网址："
        '
        'tbWebsiteURL
        '
        Me.tbWebsiteURL.Location = New System.Drawing.Point(84, 8)
        Me.tbWebsiteURL.Margin = New System.Windows.Forms.Padding(4)
        Me.tbWebsiteURL.Multiline = True
        Me.tbWebsiteURL.Name = "tbWebsiteURL"
        Me.tbWebsiteURL.Size = New System.Drawing.Size(380, 58)
        Me.tbWebsiteURL.TabIndex = 1
        '
        'functionTab
        '
        Me.functionTab.Controls.Add(Me.manageTabPage)
        Me.functionTab.Controls.Add(Me.tasksTabPage)
        Me.functionTab.Location = New System.Drawing.Point(13, 13)
        Me.functionTab.Margin = New System.Windows.Forms.Padding(4)
        Me.functionTab.Multiline = True
        Me.functionTab.Name = "functionTab"
        Me.functionTab.SelectedIndex = 0
        Me.functionTab.Size = New System.Drawing.Size(480, 350)
        Me.functionTab.TabIndex = 0
        '
        'manageTabPage
        '
        Me.manageTabPage.Controls.Add(Me.lbProxyAddr)
        Me.manageTabPage.Controls.Add(Me.lbProxyPort)
        Me.manageTabPage.Controls.Add(Me.tbProxyPort)
        Me.manageTabPage.Controls.Add(Me.tbProxyAddr)
        Me.manageTabPage.Controls.Add(Me.chkbProxy)
        Me.manageTabPage.Controls.Add(Me.parseProgressBar)
        Me.manageTabPage.Controls.Add(Me.lbVideoLink)
        Me.manageTabPage.Controls.Add(Me.lbWebSiteURL)
        Me.manageTabPage.Controls.Add(Me.btDownVideo)
        Me.manageTabPage.Controls.Add(Me.btParseURL)
        Me.manageTabPage.Controls.Add(Me.btClean)
        Me.manageTabPage.Controls.Add(Me.tbVideoLink)
        Me.manageTabPage.Controls.Add(Me.tbWebsiteURL)
        Me.manageTabPage.Location = New System.Drawing.Point(4, 26)
        Me.manageTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.manageTabPage.Name = "manageTabPage"
        Me.manageTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.manageTabPage.Size = New System.Drawing.Size(472, 320)
        Me.manageTabPage.TabIndex = 0
        Me.manageTabPage.Text = "任务管理"
        Me.manageTabPage.UseVisualStyleBackColor = True
        '
        'lbProxyAddr
        '
        Me.lbProxyAddr.AutoSize = True
        Me.lbProxyAddr.Location = New System.Drawing.Point(194, 292)
        Me.lbProxyAddr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProxyAddr.Name = "lbProxyAddr"
        Me.lbProxyAddr.Size = New System.Drawing.Size(47, 17)
        Me.lbProxyAddr.TabIndex = 10
        Me.lbProxyAddr.Text = "服务器:"
        '
        'lbProxyPort
        '
        Me.lbProxyPort.AutoSize = True
        Me.lbProxyPort.Location = New System.Drawing.Point(373, 292)
        Me.lbProxyPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProxyPort.Name = "lbProxyPort"
        Me.lbProxyPort.Size = New System.Drawing.Size(35, 17)
        Me.lbProxyPort.TabIndex = 9
        Me.lbProxyPort.Text = "端口:"
        '
        'tbProxyPort
        '
        Me.tbProxyPort.Enabled = False
        Me.tbProxyPort.Location = New System.Drawing.Point(416, 289)
        Me.tbProxyPort.Margin = New System.Windows.Forms.Padding(4)
        Me.tbProxyPort.Name = "tbProxyPort"
        Me.tbProxyPort.Size = New System.Drawing.Size(48, 23)
        Me.tbProxyPort.TabIndex = 9
        Me.tbProxyPort.Text = "8080"
        '
        'tbProxyAddr
        '
        Me.tbProxyAddr.Enabled = False
        Me.tbProxyAddr.Location = New System.Drawing.Point(249, 289)
        Me.tbProxyAddr.Margin = New System.Windows.Forms.Padding(4)
        Me.tbProxyAddr.Name = "tbProxyAddr"
        Me.tbProxyAddr.Size = New System.Drawing.Size(116, 23)
        Me.tbProxyAddr.TabIndex = 8
        Me.tbProxyAddr.Text = "127.0.0.1"
        '
        'chkbProxy
        '
        Me.chkbProxy.AutoSize = True
        Me.chkbProxy.Location = New System.Drawing.Point(11, 288)
        Me.chkbProxy.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbProxy.Name = "chkbProxy"
        Me.chkbProxy.Size = New System.Drawing.Size(75, 21)
        Me.chkbProxy.TabIndex = 7
        Me.chkbProxy.Text = "使用代理"
        Me.chkbProxy.UseVisualStyleBackColor = True
        '
        'parseProgressBar
        '
        Me.parseProgressBar.Location = New System.Drawing.Point(11, 229)
        Me.parseProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.parseProgressBar.Name = "parseProgressBar"
        Me.parseProgressBar.Size = New System.Drawing.Size(145, 24)
        Me.parseProgressBar.TabIndex = 6
        '
        'lbVideoLink
        '
        Me.lbVideoLink.AutoSize = True
        Me.lbVideoLink.Location = New System.Drawing.Point(8, 77)
        Me.lbVideoLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbVideoLink.Name = "lbVideoLink"
        Me.lbVideoLink.Size = New System.Drawing.Size(68, 17)
        Me.lbVideoLink.TabIndex = 1
        Me.lbVideoLink.Text = "视频链接："
        '
        'btDownVideo
        '
        Me.btDownVideo.Location = New System.Drawing.Point(372, 222)
        Me.btDownVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.btDownVideo.Name = "btDownVideo"
        Me.btDownVideo.Size = New System.Drawing.Size(92, 38)
        Me.btDownVideo.TabIndex = 5
        Me.btDownVideo.Text = "下载视频"
        Me.btDownVideo.UseVisualStyleBackColor = True
        '
        'btParseURL
        '
        Me.btParseURL.Location = New System.Drawing.Point(272, 222)
        Me.btParseURL.Margin = New System.Windows.Forms.Padding(4)
        Me.btParseURL.Name = "btParseURL"
        Me.btParseURL.Size = New System.Drawing.Size(92, 38)
        Me.btParseURL.TabIndex = 4
        Me.btParseURL.Text = "解析链接"
        Me.btParseURL.UseVisualStyleBackColor = True
        '
        'tbVideoLink
        '
        Me.tbVideoLink.Location = New System.Drawing.Point(84, 74)
        Me.tbVideoLink.Margin = New System.Windows.Forms.Padding(4)
        Me.tbVideoLink.Multiline = True
        Me.tbVideoLink.Name = "tbVideoLink"
        Me.tbVideoLink.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbVideoLink.Size = New System.Drawing.Size(380, 140)
        Me.tbVideoLink.TabIndex = 2
        '
        'tasksTabPage
        '
        Me.tasksTabPage.Controls.Add(Me.lbDownProg)
        Me.tasksTabPage.Controls.Add(Me.btSavePath)
        Me.tasksTabPage.Controls.Add(Me.prgbarDownload)
        Me.tasksTabPage.Location = New System.Drawing.Point(4, 26)
        Me.tasksTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.tasksTabPage.Name = "tasksTabPage"
        Me.tasksTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.tasksTabPage.Size = New System.Drawing.Size(472, 320)
        Me.tasksTabPage.TabIndex = 1
        Me.tasksTabPage.Text = "下载队列"
        Me.tasksTabPage.UseVisualStyleBackColor = True
        '
        'lbDownProg
        '
        Me.lbDownProg.AutoSize = True
        Me.lbDownProg.Location = New System.Drawing.Point(7, 39)
        Me.lbDownProg.Name = "lbDownProg"
        Me.lbDownProg.Size = New System.Drawing.Size(107, 17)
        Me.lbDownProg.TabIndex = 2
        Me.lbDownProg.Text = "下载进度：Na/Na"
        Me.lbDownProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btSavePath
        '
        Me.btSavePath.Location = New System.Drawing.Point(373, 39)
        Me.btSavePath.Name = "btSavePath"
        Me.btSavePath.Size = New System.Drawing.Size(92, 38)
        Me.btSavePath.TabIndex = 1
        Me.btSavePath.Text = "保存位置"
        Me.btSavePath.UseVisualStyleBackColor = True
        '
        'prgbarDownload
        '
        Me.prgbarDownload.Location = New System.Drawing.Point(7, 7)
        Me.prgbarDownload.Name = "prgbarDownload"
        Me.prgbarDownload.Size = New System.Drawing.Size(458, 23)
        Me.prgbarDownload.TabIndex = 0
        '
        'bgWorker
        '
        '
        'prgTimer
        '
        Me.prgTimer.Interval = 500
        '
        'downprgTimer
        '
        Me.downprgTimer.Interval = 1000
        '
        'saveFDVideo
        '
        Me.saveFDVideo.Filter = "视频文件 (*.mp4)|*.mp4"
        Me.saveFDVideo.Title = "将视频保存到"
        '
        'resetStatusTimer
        '
        Me.resetStatusTimer.Interval = 3000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 376)
        Me.Controls.Add(Me.functionTab)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website Video Downloader"
        Me.functionTab.ResumeLayout(False)
        Me.manageTabPage.ResumeLayout(False)
        Me.manageTabPage.PerformLayout()
        Me.tasksTabPage.ResumeLayout(False)
        Me.tasksTabPage.PerformLayout()
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
    Friend WithEvents lbProxyAddr As Label
    Friend WithEvents lbProxyPort As Label
    Friend WithEvents tbProxyPort As TextBox
    Friend WithEvents tbProxyAddr As TextBox
    Friend WithEvents chkbProxy As CheckBox
    Friend WithEvents prgbarDownload As ProgressBar
    Friend WithEvents downprgTimer As Timer
    Friend WithEvents btSavePath As Button
    Friend WithEvents lbDownProg As Label
    Friend WithEvents saveFDVideo As SaveFileDialog
    Friend WithEvents resetStatusTimer As Timer
End Class
