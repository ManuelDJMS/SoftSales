Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Module Conexiones
    'Public conexion As String = "Data source=169.254.227.121; initial catalog=SoftSales; user id=Cajero; password=12345"
    'Public conexionBit As String = "Data source=169.254.227.121; initial catalog=Bitacora; user id=Cajero; password=12345"
    Public conexion As String = "Data source=ASUSMANUEL; initial catalog=SoftSales; integrated security=true"
    Public conexionBit As String = "Data source=ASUSMANUEL; initial catalog=Bitacora; integrated security=true"
    'Public conexionMaster As String = "Data source=169.254.227.121; initial catalog=master; user id=Cajero; password=12345"
    Public conexionMaster As String = "Data source=ASUSMANUEL; initial catalog=master; integrated security=true"
    Public conexionejemploG As String
    Public usuario As Integer
    Public nombreusuario As String
    Public idEmpleado As Integer
    Public consultaventa As String 'Variable para almacemar la vemta a consultar
    Public Encontrado As String
    'esta variable me ayuda a encontrar un repetido en un datagrid
    Public ds As New DataSet
    Public da As OleDbDataAdapter
    Public aceptar As Boolean 'esta variable es para los msgbox true y false
    Public pagos As Boolean 'Esta variable es para saber si el monto no es mayor al importe de las ventas
    Public pagoscheque As Boolean 'Esta variable es para saber si el monto no es mayor al importe de cheques
    'Permitir conectarnos con nuestro archivo de excel'
    Public conn As OleDbConnection
    'Permitir conectarnos a nuestra base de datos sqlserver'
    Public cnn As SqlConnection
    Public sqlBC As SqlBulkCopy
    Public caja As String 'variable que guarda el numero de caja para crear el folio
    Public descuento As Decimal ' variable para los descuentos de las ofertas del dia
    Public codigo As Integer = 0 'variable para sacar el codigo de barras del producto vario
    Public autorizacion As String 'Variable para saber que autorizacion se aplicara
    Public idsesion As Integer 'Varibale para guaradr el idsesion para el corte de caja
    Public idcierre As Integer 'Varibale para guaradr el idsesion para el corte de 
    Public efectivo As Decimal
    Public tarjeta As Decimal
    Public cheque As Decimal
    Public gastos As Decimal
    Public totalgeneral As Decimal

    Sub limpiarCampos1(ByVal formulario As Panel)
        Dim Text As Object
        Dim Text1 As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTemp As TextBox = CType(Text, TextBox)
                txtTemp.Text = ""
                txtTemp.Enabled = True
            End If
        Next
        For Each Text1 In formulario.Controls
            If TypeOf Text1 Is ComboBox Then
                Dim txtTemp As ComboBox = CType(Text1, ComboBox)
                txtTemp.DropDownStyle = ComboBoxStyle.DropDown
                txtTemp.Text = ""
                txtTemp.Enabled = True
            End If
        Next
    End Sub
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub Bitacora(Formulario As String, Evento As String, error1 As String, Descripcion As String)
        Try
            Dim conexion As New SqlConnection("Data source=VENTACAÑON-PC\SQLEXPRESS; initial catalog=master; integrated security=true")

            conexion.Open()
            Dim comando As SqlCommand = conexion.CreateCommand()
            Dim r As String
            Dim I As Integer
            Dim x As String
            Dim fechas As String
            fechas = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
            x = "'"
            For I = 1 To Len(error1)
                If Mid(error1, I, 1) = Chr(39) Then
                    x = x & "'"
                Else
                    x = x & Mid(error1, I, 1)
                End If
            Next
            error1 = x
            r = "insert into Resultados(Formulario, Evento, Error, Descripcion, Fecha) values ('" & Formulario & "','" & Evento & "'," & error1 & "','" & Descripcion & "','" & fechas & "')"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Sub deshaCampos(ByVal formulario As Panel)
        Dim Text As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTemp As TextBox = CType(Text, TextBox)
                txtTemp.Text = ""
                txtTemp.Enabled = False
            End If
        Next
    End Sub
    Sub habCampos(ByVal formulario As Panel)
        Dim Text As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTemp As TextBox = CType(Text, TextBox)
                txtTemp.Enabled = True
            End If
        Next
        For Each Text In formulario.Controls
            If TypeOf Text Is MaskedTextBox Then
                Dim txtTemp As MaskedTextBox = CType(Text, MaskedTextBox)
                txtTemp.Enabled = True
            End If
        Next
    End Sub
    Dim sUnidades() As String =
    {"", "un", "dos", "tres", "cuatro", "cinco",
    "seis", "siete", "ocho", "nueve", "diez",
    "once", "doce", "trece", "catorce",
    "quince", "dieciseis",
    "diecisiete", "dieciocho", "diecinueve", "veinte",
    "veintiún", "veintidos", "veintitres", "veinticuatro",
    "veinticinco", "veintiseis", "veintisiete",
    "veintiocho", "veintinueve"}

    Dim sDecenas() As String =
    {"", "diez", "veinte", "treinta", "cuarenta", "cincuenta",
    "sesenta", "setenta", "ochenta", "noventa"}

    Dim sCentenas() As String =
    {"", "ciento", "doscientos", "trescientos",
    "cuatrocientos",
    "quinientos", "seiscientos", "setecientos",
    "ochocientos", "novecientos"}
    Dim sResultado As String = ""
    Public Function ConvertirNumero(ByVal dNumero As Double) As String
        Dim dNumAux As Double = 0
        ' Dim x As String
        Dim sAux As String

        sResultado = " "

        If (dNumero > 999999999999) Then
            Return ""
        End If
        If (dNumero > 999999999) Then
            dNumAux = dNumero Mod 1000000000000
            sResultado += Numeros(dNumAux, 1000000000) + " mil "
        End If

        If (dNumero > 999999) Then
            dNumAux = dNumero Mod 1000000000
            sResultado += Numeros(dNumAux, 1000000) + " millones "
        End If

        If (dNumero > 999) Then
            dNumAux = dNumero Mod 1000000
            If (dNumAux >= 1000 And dNumAux < 1999) Then
                sResultado += " mil "
            Else
                sResultado += Numeros(dNumAux, 1000) + " mil "
            End If
        End If

        dNumAux = dNumero Mod 1000
        sResultado += Numeros(dNumAux, 1)


        ''Enseguida verificamos si contiene punto, 
        ''si es así, los convertimos a texto.
        sAux = dNumero.ToString()
        Dim varDecimales As String = ""
        If (sAux.IndexOf(".") >= 0) Then
            varDecimales = ObtenerDecimales(sAux)

        Else
            varDecimales = "pesos 00"
        End If
        sResultado += varDecimales
        Return (sResultado + "/100 M.N").ToUpper
    End Function



    Private Function Numeros(ByVal dNumAux As Double, ByVal dFactor As Double) As String
        Dim dCociente As Double = dNumAux / dFactor
        Dim dNumero As Double = 0
        Dim iNumero As Integer = 0
        Dim sNumero As String = ""
        Dim sTexto As String = ""

        If (dCociente >= 100) Then
            dNumero = dCociente / 100
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())

            sTexto += sCentenas(iNumero) + " "
       
        End If

        dCociente = dCociente Mod 100
        If (dCociente >= 30) Then
            dNumero = dCociente / 10
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())
            If (iNumero > 0) Then
                sTexto += sDecenas(iNumero) + " "
            End If

            dNumero = dCociente Mod 10
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())
            If (iNumero > 0) Then
                sTexto += "y " + sUnidades(iNumero) + " "
            End If

        Else
            dNumero = dCociente
            sNumero = dNumero.ToString()
            If (sNumero.Length > 1) Then
                If (sNumero(1) <> ".") Then
                    iNumero = Integer.Parse(sNumero(0).ToString() +
                        sNumero(1).ToString())
                    sTexto += sUnidades(iNumero) + " "

                Else
                        iNumero = Integer.Parse(sNumero(0).ToString())
                    sTexto += sUnidades(iNumero) + " "
                    End If
            Else
                iNumero = Integer.Parse(sNumero(0).ToString())
                sTexto += sUnidades(iNumero) + " "

            End If
        End If

        Return sTexto
    End Function


    Private Function ObtenerDecimales(ByVal sNumero As String) As String
        Dim sNumPuntos() As String
        Dim sTexto As String = ""
        Dim dNumero As Double = 0
        Dim dnumeroconvert As String
        sNumPuntos = sNumero.Split(".")
        dNumero = Convert.ToDouble(sNumPuntos(1))
        dNumero = dNumero * 9 + dNumero
        'MsgBox(dNumero)
        dnumeroconvert = dNumero.ToString
        'sTexto = "punto " + Numeros(dNumero, 1)
        sTexto = "pesos " + dnumeroconvert
        Return sTexto
    End Function
End Module
