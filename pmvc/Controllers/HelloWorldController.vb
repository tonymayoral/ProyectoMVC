Namespace pmvc
    Public Class HelloWorldController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /HelloWorld

        Function Index() As ActionResult
            Return View()
        End Function

        '
        ' GET: /HelloWorld/welcome

        Function Welcome(nombre As String, Optional num As Integer = 1) As ActionResult

            ViewBag.Message = "hola" & nombre
            ViewBag.NumTimes = num

            'un cambio de prueba


            'cambio correspondiente a un requerimiento
            'tb se pondróa el id de la tarea de bugnet

            Return View()
        End Function

    End Class
End Namespace