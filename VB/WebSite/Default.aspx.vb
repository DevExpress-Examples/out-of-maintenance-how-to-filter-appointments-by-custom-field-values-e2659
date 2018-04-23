Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		LoadSchedulerData()

		If (Not IsPostBack) Then
			ASPxScheduler1.Start = New DateTime(2008, 7, 12)
		End If
	End Sub

	Protected Sub ASPxScheduler1_FilterAppointment(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs)
		Dim customFieldName As String = "Price"
		Dim customFieldValue As Double
		Dim filteredValue As Double

		If Double.TryParse(e.Object.CustomFields(customFieldName).ToString(), customFieldValue) AndAlso Double.TryParse(Me.HiddenField1.Value, filteredValue) Then
			e.Cancel = (customFieldValue = filteredValue)
		End If
	End Sub

	Private Sub LoadSchedulerData()
		Dim dataTable As New DataTable("CarScheduling")

		dataTable.ReadXml(HttpContext.Current.Server.MapPath("~/App_Data/CarScheduling.xml"))
		ASPxScheduler1.AppointmentDataSource = dataTable
		ASPxScheduler1.DataBind()
	End Sub
End Class
