Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class SeleccionarAñoCurso
    Dim ipServidor As String = "192.168.1.55"
    Dim claveBD As String
    Dim servidorSQL As String
    Dim basededatos As String = "matriculas_ll"
    Dim usuarioBD As String = "servidorbdd"
    Dim strcon As String
    Public dreader As SqlDataReader
    Dim conector As New SqlConnection("server= 192.168.1.55,1433 ;user='servidorbdd';password= '1234321' ; database=matriculas_ll")

    Dim cmd As OleDbDataAdapter
    Dim cnn As OleDbConnection

    Private Sub SeleccionarAñoCurso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MostrarAñoParaCurso()
       
    End Sub
    Sub MostrarAñoParaCurso()

        conector.Close()
        conector.Open()
        Dim qry As String = "select year(matricula.fecha_matricula) from matricula,alumno where alumno.rut_alumno = matricula.rut_alumno and alumno.estado='activo'"
        Dim sqlcmd As New SqlCommand(qry, conector)
        Dim drc As Integer
        drc = sqlcmd.ExecuteScalar
        ComboBox1.SelectionStart = drc.ToString
        conector.Close()
        conector.Close()
        conector.Close()


    End Sub


End Class