Imports System.ComponentModel
Imports System.IO

Public Class Main

    '定义链接解析工具目录
    Dim ParseToolPath As String
    Dim parseResult As String

    '链接解析函数
    Private Function VideoURLParse(ByVal websiteURL As String) As String
        Dim procURLParse As New Process
        With procURLParse.StartInfo
            .FileName = (ParseToolPath)
            .Arguments = " -g " + websiteURL
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

    '声明异步委托GetURLParseResult
    Private Delegate Function AsyncVideoURLParse(websiteURL As String) As String


    '程序启动时释放链接解析工具到运行目录
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        ParseToolPath = Application.StartupPath + "\URLParse.exe"
        Dim parseRes() As Byte = My.Resources.ThirdPartyRes.URLParse
        Dim thirdAppFile As IO.Stream = File.Create(ParseToolPath)
        thirdAppFile.Write(parseRes, 0, parseRes.Length)
        thirdAppFile.Close()
        SetAttr(ParseToolPath, FileAttribute.Hidden)
    End Sub

    '程序退出时删除连接解析工具
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Computer.FileSystem.DeleteFile(ParseToolPath)
    End Sub

    Private Sub BtParseURL_Click(sender As Object, e As EventArgs) Handles btParseURL.Click
        '判断是否填写视频网址并执行解析任务
        If tbWebsiteURL.Text <> Nothing Then
            bgWorker.RunWorkerAsync()
            prgTimer.Start()
        Else
            MsgBox("请输入视频网址！", vbCritical)
        End If
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        Dim url As String = tbWebsiteURL.Text
        parseResult = VideoURLParse(url)
    End Sub

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

    Private Sub BtClean_Click(sender As Object, e As EventArgs) Handles btClean.Click
        tbWebsiteURL.ResetText()
        tbVideoLink.ResetText()
    End Sub
End Class
