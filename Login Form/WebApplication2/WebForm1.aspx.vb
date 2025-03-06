Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ((TextBox1.Text = "GNC") And (TextBox2.Text = "122")) Then
            Response.Write("login successfully")
        Else
            Response.Write("invalid credentials")
        End If
    End Sub

End Class