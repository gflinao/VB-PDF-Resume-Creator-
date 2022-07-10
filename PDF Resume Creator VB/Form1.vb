Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw



Public Class ResCre
    Private Sub BtnGen_Click(sender As Object, e As EventArgs) Handles BtnGen.Click

        Dim jsonpath As String = "C:\Users\admin\source\repos\PDF Resume Creator VB\PDF Resume Creator VB\Data\ResumeJson.json"
        Dim jsonopen As String = File.ReadAllText(jsonpath)
        Dim jsonoutp As Jsonoutp = JsonConvert.DeserializeObject(Of Jsonoutp)(jsonopen)
        Dim ResCrePDF As New Document()
        PdfWriter.GetInstance(ResCrePDF, New FileStream("C:\Users\admin\source\repos\PDF Resume Creator VB\PDF Resume Creator VB\Data\LINAO_GENREV.pdf", FileMode.Create))

        Dim main_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 22, iTextSharp.text.Font.BOLD)
        Dim lessmain_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 17, iTextSharp.text.Font.BOLD)
        Dim second_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD)
        Dim normal_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL)
        Dim smaller_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 10, iTextSharp.text.Font.NORMAL)
        Dim space_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 5, iTextSharp.text.Font.NORMAL)
        Dim normal_bold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.ITALIC)

        Dim Fname As New Paragraph(jsonoutp.FullName)
        Dim Scourse As New Paragraph(jsonoutp.Course)

        ResCrePDF.Open()
        ResCrePDF.Add(Fname)
        ResCrePDF.Add(Scourse)
        ResCrePDF.Close()


    End Sub

    Public Class Jsonoutp

        Public Property FullName As String
        Public Property Course As String


    End Class

    Private Sub ResCre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
