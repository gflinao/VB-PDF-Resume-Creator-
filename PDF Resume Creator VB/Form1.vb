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
        Dim break As New LineSeparator(3.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim space As New Paragraph("")

        Dim Fname As New Paragraph(jsonoutp.FullName & vbLf, main_font)
        Dim Scourse As New Paragraph(jsonoutp.Course)
        Dim Add As New Paragraph(jsonoutp.Address)
        Dim PhNumber As New Paragraph(jsonoutp.PhoneNumber)
        Dim EAdd As New Paragraph(jsonoutp.EmailAdd)
        Dim AbInfo As New Paragraph(jsonoutp.AboutInfo)
        Dim EdHead As New Paragraph(jsonoutp.EducHead)
        Dim Syear As New Paragraph(jsonoutp.Cyear)
        Dim Sschool As New Paragraph(jsonoutp.Cschool)
        Dim HighSc As New Paragraph(jsonoutp.HS)
        Dim Hyear As New Paragraph(jsonoutp.HSyear)
        Dim Hschoool As New Paragraph(jsonoutp.HSschool)
        Dim SHead As New Paragraph(jsonoutp.SkillHead)
        Dim S1 As New Paragraph(jsonoutp.Skill1)
        Dim S2 As New Paragraph(jsonoutp.Skill2)
        Dim S3 As New Paragraph(jsonoutp.Skill3)

        ResCrePDF.Open()
        ResCrePDF.Add(Fname)
        ResCrePDF.Add(Scourse)
        ResCrePDF.Add(Add)
        ResCrePDF.Add(PhNumber)
        ResCrePDF.Add(EAdd)
        ResCrePDF.Add(AbInfo)
        ResCrePDF.Add(EdHead)
        ResCrePDF.Add(Syear)
        ResCrePDF.Add(Sschool)
        ResCrePDF.Add(HighSc)
        ResCrePDF.Add(Hyear)
        ResCrePDF.Add(Hschoool)
        ResCrePDF.Add(SHead)
        ResCrePDF.Add(S1)
        ResCrePDF.Add(S2)
        ResCrePDF.Add(S3)
        ResCrePDF.Close()


    End Sub

    Public Class Jsonoutp

        Public Property FullName As String
        Public Property Course As String
        Public Property Address As String
        Public Property PhoneNumber As String
        Public Property EmailAdd As String
        Public Property AboutInfo As String
        Public Property EducHead As String
        Public Property Cyear As String
        Public Property Cschool As String
        Public Property HS As String
        Public Property HSyear As String
        Public Property HSschool As String
        Public Property SkillHead As String
        Public Property Skill1 As String
        Public Property Skill2 As String
        Public Property Skill3 As String

    End Class

    Private Sub ResCre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
