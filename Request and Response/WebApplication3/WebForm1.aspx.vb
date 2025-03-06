Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("NAME : " & Request.Form("NAME") & "<br>" & "ROLLNO : " & Request.Form("ROLLNO") & "<br>" & "MARK : " & Request.Form("MARK") & "<br>")
    End Sub

End Class