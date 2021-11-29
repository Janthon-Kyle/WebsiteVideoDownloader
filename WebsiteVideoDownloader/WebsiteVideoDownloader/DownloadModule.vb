Imports System.ComponentModel
Imports System.Net
Module DownloadModule

    Private WithEvents DownloadClient As New WebClient
    Private FileDownloadTotalSize As Double
    Private FileDownloadReceived As Double
    Private FileDownloadPercentage As Integer

    ''' <summary>
    ''' 文件下载，用于下载资源文件
    ''' </summary>
    ''' <param name="fileUri">需要下载的文件Uri</param>
    ''' <param name="fileSaveName">文件保存目录及名称</param>
    Public Sub FileDownload(ByVal fileUri As String, ByVal fileSaveName As String)
        '若参数Uri为空，则抛出程序异常
        If fileUri = vbNullString Then
            Throw New ApplicationException("请输入下载链接！")
        End If
        DownloadClient.DownloadFileAsync(New Uri(fileUri), fileSaveName)
    End Sub

    '自动更新下载进度数据
    Private Sub DownloadClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles DownloadClient.DownloadProgressChanged
        FileDownloadTotalSize = e.TotalBytesToReceive / 1024 / 1024
        FileDownloadReceived = e.BytesReceived / 1024 / 1024
        FileDownloadPercentage = e.ProgressPercentage
    End Sub

    Public Sub CleanFinishedStatus()
        FileDownloadPercentage = Nothing
    End Sub

    Public Function GetFileTotalSize() As Double
        Return FileDownloadTotalSize
    End Function

    Public Function GetFileRecevied() As Double
        Return FileDownloadReceived
    End Function

    Public Function GetDownloadPercentage()
        Return FileDownloadPercentage
    End Function
End Module
