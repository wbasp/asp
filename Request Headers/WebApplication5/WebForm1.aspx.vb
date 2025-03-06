Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        lblmessage1.Text = "<Table>"
        For i = 0 To Request.Headers.Count - 1
            lblmessage1.Text = lblmessage1.Text & "<TR><TD><B>" &
            Request.Headers.GetKey(i) & "<B></TD><TD>" & Request.Headers(i) & "</TD></TR>"
        Next
        lblmessage1.Text = lblmessage1.Text & "</TABLE>"
    End Sub

End Class