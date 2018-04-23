# How to filter appointments by custom field values


<p>This example illustrates how to filter appointments by custom field values. A particular value is selected via the ASPxComboBox. In the ASPxClientComboBox.SelectedIndexChanged event handler this value is stored in the HiddenField and the scheduler is refreshed via the ASPxClientScheduler.Refresh() method. Then, on the server side, the ASPxScheduler.FilterAppointment event handler is fired. The value from the HiddenField is used to filter appointments.</p>

<br/>


