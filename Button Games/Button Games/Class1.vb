Imports System.Drawing
Public Class BtnPlay
    Inherits Windows.Forms.Button
    Public Sub New()
        Me.Size = New Point(32, 32)
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = My.Resources.Picture4
        Me.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub BtnPlay_MouseDown(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.BackgroundImage = My.Resources.Picture2
    End Sub

    Private Sub BtnPlay_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.BackgroundImage = My.Resources.Picture3
    End Sub

    Private Sub BtnPlay_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.Picture4
    End Sub

    Private Sub BtnPlay_MouseUp(sender As Object, e As Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.BackgroundImage = My.Resources.Picture3
    End Sub
End Class
