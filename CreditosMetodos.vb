Public Class CreditosMetodos
    Public Property login As String
    Public Property pLogin() As String
        Get
            Return login
        End Get
        Set(ByVal value As String)
            login = value
        End Set
    End Property
    Public Property avatar_url As String
    Public Property pAvatar() As String
        Get
            Return avatar_url
        End Get
        Set(ByVal value As String)
            avatar_url = value
        End Set
    End Property
    Public Property public_repos As Integer
    Public Property pRepos() As String
        Get
            Return public_repos
        End Get
        Set(ByVal value As String)
            public_repos = value
        End Set
    End Property

End Class
