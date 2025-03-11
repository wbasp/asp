Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
myanchor.Attributes.Add("onmouseover",

"child=window.open('welcome.aspx','a',top=200,left=250,width=500,height=300);")

myanchor.Attributes.Add("onmouseout", "child.close();")


    End Sub

End Class
