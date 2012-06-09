Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Public Class Movie
    Public Property ID As Integer

    <Required()>
    Public Property Title As String
    <DataType(DataType.DateTime)>
    Public Property ReleaseDate As DateTime

    Public Property Genre As String
    <Range(1, 100)>
    <DataType(DataType.Currency)>
    <DisplayFormat(DataFormatString:="{0:c}")>
    Public Property Price As Decimal
    <StringLength(5)>
    Public Property Rating As String

End Class

Public Class MovieDBContext
    Inherits DbContext


    Public Property Movies As DbSet(Of Movie)

End Class