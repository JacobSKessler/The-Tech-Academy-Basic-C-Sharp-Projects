Imports System.Web.Mvc

Namespace Controllers
    Public Class StudentController : Controller

        Private String _connectionString = @"Data Source=DESKTOP-5K61KI0\SQLEXPRESS;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        ' GET: Student
        Function Index() As ActionResult

            Return View()
        End Function
    End Class
End Namespace