Public Class iPanel
    Inherits Panel
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.ExStyle = CP.ExStyle Or &H20
            Return CP
        End Get
    End Property
End Class
