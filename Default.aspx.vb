Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        System.Diagnostics.Debug.WriteLine("test2")
        HelloWorldLabel.Text = "This label text was changed at runtime"
    End Sub

    Protected Sub button_click(sender As Object, e As EventArgs) Handles GreetButton.Click
        HelloWorldLabel.Text = "This now has whatever you put in the input: , " + TextInput.Text
    End Sub
End Class