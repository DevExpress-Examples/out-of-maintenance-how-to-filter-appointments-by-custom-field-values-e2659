<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2659)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomVerticalAppointmentTemplate.ascx](./CS/WebSite/CustomSchedulerForms/CustomVerticalAppointmentTemplate.ascx) (VB: [CustomVerticalAppointmentTemplate.ascx](./VB/WebSite/CustomSchedulerForms/CustomVerticalAppointmentTemplate.ascx))
* [CustomVerticalAppointmentTemplate.ascx.cs](./CS/WebSite/CustomSchedulerForms/CustomVerticalAppointmentTemplate.ascx.cs) (VB: [CustomVerticalAppointmentTemplate.ascx.vb](./VB/WebSite/CustomSchedulerForms/CustomVerticalAppointmentTemplate.ascx.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to filter appointments by custom field values
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2659/)**
<!-- run online end -->


<p>This example illustrates how to filter appointments by custom field values. A particular value is selected via the ASPxComboBox. In the ASPxClientComboBox.SelectedIndexChanged event handler this value is stored in the HiddenField and the scheduler is refreshed via the ASPxClientScheduler.Refresh() method. Then, on the server side, the ASPxScheduler.FilterAppointment event handler is fired. The value from the HiddenField is used to filter appointments.</p>

<br/>


