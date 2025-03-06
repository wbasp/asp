Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d As Date
        Dim da As Date
        d = FormatDateTime(Now, 2)
        da = DateAdd(DateInterval.Day, 10, d)
        text4.Text = "date of booking:" & d
        text5.Text = "Your order has been booked.. & will be delivered on or before:" & da
    End Sub

End Class