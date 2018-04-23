using System;
using System.Data;
using System.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        LoadSchedulerData();

        if (!IsPostBack) {
            ASPxScheduler1.Start = new DateTime(2008, 7, 12);
        }
    }

    protected void ASPxScheduler1_FilterAppointment(object sender, DevExpress.XtraScheduler.PersistentObjectCancelEventArgs e) {
        string customFieldName = "Price";
        double customFieldValue;
        double filteredValue;

        if (double.TryParse(e.Object.CustomFields[customFieldName].ToString(), out customFieldValue) && double.TryParse(this.HiddenField1.Value, out filteredValue)) {
            e.Cancel = (customFieldValue == filteredValue);
        }
    }

    private void LoadSchedulerData() {
        DataTable dataTable = new DataTable("CarScheduling");

        dataTable.ReadXml(HttpContext.Current.Server.MapPath("~/App_Data/CarScheduling.xml"));
        ASPxScheduler1.AppointmentDataSource = dataTable;
        ASPxScheduler1.DataBind();
    }
}
