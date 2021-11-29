Imports System.ComponentModel
Imports System.Net

Public Class Main

    '定义链接解析工具目录
    Dim ParseToolPath As String
    Dim VideoSavePath As String
    Dim parseResult As String

    '链接解析函数
    Private Function VideoURLParse(ByVal websiteURL As String) As String
        Dim procURLParse As New Process
        With procURLParse.StartInfo
            .FileName = (ParseToolPath)
            '判断是否启用代理，以改变运行参数
            If chkbProxy.CheckState = CheckState.Checked Then
                .Arguments = " -g " + websiteURL + " --proxy http://" + tbProxyAddr.Text + ":" + tbProxyPort.Text
            Else
                .Arguments = " -g " + websiteURL
            End If
            .UseShellExecute = False
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True
        End With
        procURLParse.Start()
        Dim videoLink As String = procURLParse.StandardOutput.ReadToEnd
        procURLParse.Close()
        Return videoLink
    End Function

    '程序启动时释放链接解析工具到运行目录
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ParseToolPath = Application.StartupPath + "\URLParse.exe"
        Dim MyVideoDir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        saveFDVideo.InitialDirectory = MyVideoDir
        VideoSavePath = MyVideoDir + "\DownloadedVideo.mp4"
        '旧代码IO流写入
        'Dim parseRes() As Byte = My.Resources.ThirdPartyRes.URLParse
        'Dim thirdAppFile As IO.Stream = File.Create(ParseToolPath)
        'thirdAppFile.Write(parseRes, 0, parseRes.Length)
        'thirdAppFile.Close()
        'SetAttr(ParseToolPath, FileAttribute.Hidden)

        '新代码使用My.Computer.FileSystem写入
WriteURLParseTool:
        My.Computer.FileSystem.WriteAllBytes(ParseToolPath, My.Resources.ThirdPartyRes.URLParse, False)
        If My.Computer.FileSystem.FileExists(ParseToolPath) = True Then
            SetAttr(ParseToolPath, FileAttribute.Hidden)
        Else
            GoTo WriteURLParseTool
        End If
    End Sub

    '程序退出时删除连接解析工具
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Computer.FileSystem.DeleteFile(ParseToolPath)
    End Sub

    '判断是否填写视频网址并执行解析任务
    Private Sub BtParseURL_Click(sender As Object, e As EventArgs) Handles btParseURL.Click
        If tbWebsiteURL.Text <> Nothing Then
            bgWorker.RunWorkerAsync()
            prgTimer.Start()
        Else
            MsgBox("请输入视频网址！", vbCritical, "提示")
        End If
    End Sub

    '异步调用链接解析函数
    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim url As String = tbWebsiteURL.Text
        parseResult = VideoURLParse(url)
    End Sub

    '获取链接解析进度
    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles prgTimer.Tick
        If bgWorker.IsBusy = True Then
            tbVideoLink.Text = "正在解析..."
            parseProgressBar.Style = ProgressBarStyle.Marquee
        Else
            tbVideoLink.ResetText()
            tbVideoLink.Text = parseResult
            prgTimer.Stop()
            parseProgressBar.Style = ProgressBarStyle.Blocks
        End If
    End Sub

    '一键清空输入框参数
    Private Sub BtClean_Click(sender As Object, e As EventArgs) Handles btClean.Click
        tbWebsiteURL.ResetText()
        tbVideoLink.ResetText()
    End Sub

    '切换是否使用代理模式
    Private Sub ChkbProxy_CheckedChanged(sender As Object, e As EventArgs) Handles chkbProxy.CheckedChanged
        If chkbProxy.CheckState = CheckState.Checked Then
            tbProxyAddr.Enabled = True
            tbProxyPort.Enabled = True
        Else
            tbProxyAddr.Enabled = False
            tbProxyPort.Enabled = False
        End If
    End Sub

    '触发下载视频操作
    Private Sub BtDownVideo_Click(sender As Object, e As EventArgs) Handles btDownVideo.Click
        Dim SaveDir As String = My.Computer.FileSystem.GetParentPath(VideoSavePath)
        If My.Computer.FileSystem.DirectoryExists(SaveDir) = True Then
            FileDownload(parseResult, VideoSavePath)
            downprgTimer.Start()
        Else
            MsgBox("位置不存在，请设置保存路径！", MsgBoxStyle.Critical, "错误")
            If saveFDVideo.ShowDialog = DialogResult.OK Then
                VideoSavePath = saveFDVideo.FileName
                FileDownload(parseResult, VideoSavePath)
                downprgTimer.Start()
            End If
        End If
    End Sub

    '自动更新下载进度计时器
    Private Sub DownprgTimer_Tick(sender As Object, e As EventArgs) Handles downprgTimer.Tick
        prgbarDownload.Value = GetDownloadPercentage()
        lbDownProg.Text = "下载进度：" + Math.Round(GetFileRecevied()， 2).ToString + "MB / " + Math.Round(GetFileTotalSize(), 2).ToString + " MB"
        If GetDownloadPercentage() = 100 Then
            downprgTimer.Stop()
            lbDownProg.Text = "下载完成"
            resetStatusTimer.Start()
        End If
    End Sub

    '修改视频下载保存路径
    Private Sub BtSavePath_Click(sender As Object, e As EventArgs) Handles btSavePath.Click
        If saveFDVideo.ShowDialog = DialogResult.OK Then
            VideoSavePath = saveFDVideo.FileName
        Else
            MsgBox("未设置保存路径，视频默认保存在 [视频] 目录下。", MsgBoxStyle.Information, "提示")
        End If
    End Sub

    '下载完成重置进度条和状态
    Private Sub ResetStatusTimer_Tick(sender As Object, e As EventArgs) Handles resetStatusTimer.Tick
        CleanFinishedStatus()
        lbDownProg.Text = "下载进度：Na/Na"
        prgbarDownload.Value = GetDownloadPercentage()
        resetStatusTimer.Stop()
    End Sub
End Class
