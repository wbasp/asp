Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        LinkButton1.Attributes.Add("onmouseover",
"child=window.open('WebForm2.aspx','a',top=200,left=250,width=500,height=300);")
        LinkButton1.Attributes.Add("onmouseout", "child.close();")
    End Sub
End Class