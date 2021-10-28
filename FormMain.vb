Public Class FormMain
    Public UserADID As String
    Public UserADName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTOC.Click
        FormTOC.Show()
        FormQOC.Hide()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserADID = getADID()
        'MessageBox.Show(UserADID)
        TextID.Text = UserADID
        UserADName = getADName()
        'MessageBox.Show(UserADName)
        TextName.Text = UserADName
    End Sub

    Private Sub BtnQOC_Click(sender As Object, e As EventArgs) Handles BtnQOC.Click
        FormQOC.Show()
        FormTOC.Hide()
    End Sub

    Private Function getADID() As String
        Return Environment.GetEnvironmentVariable("USERNAME")
    End Function

    Private Function getADName() As String
        Dim objAD As Object
        Dim objUser As Object
        objAD = CreateObject("ADSystemInfo")
        objUser = GetObject("LDAP://" & objAD.UserName)
        Return objUser.DisplayName
    End Function

End Class
