using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//added the following namesapces:
using System.Data.SqlClient;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using Event_Verse_Application.Attendee_Files;

namespace Event_Verse_Application.Organizer_Files
{
    public partial class ResourceAndVendorManagement : Form
    {
        Thread threadObj;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G5900N6\\SQLEXPRESS;Initial Catalog=Event_Verse_DB;Integrated Security=True;TrustServerCertificate=True");

        public ResourceAndVendorManagement()
        {
            InitializeComponent();
            //center the form on the screen on startup:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void openOrganizerDashboard(object obj)
        {
            Application.Run(new OrganizerDashboard());
        }

        private void ResourceAndVendorManagement_Load(object sender, EventArgs e)
        {

        }

        private void backToDashboard_button_Click(object sender, EventArgs e)
        {
            //open the organizer dashboard.
            this.Close();
            threadObj = new Thread(openOrganizerDashboard);
            threadObj.SetApartmentState(ApartmentState.STA);
            threadObj.Start();
        }

        private void addVendor_button_Click(object sender, EventArgs e)
        {
            //uses the details entered to add vendor, if they do not alreayd exist to the event from the event id textbox. 
        }

        private void deleteVendor_button_Click(object sender, EventArgs e)
        {
            //the vendore is removed from the event. 
            //this would be easier to do by having seperate table for vendors and events and then linking them with a table that has the event id and vendor id.
        }

        private void updateVendor_button_Click(object sender, EventArgs e)
        {
            //use the vendor id and category provided to search for them in the vendor table and update the category information the user entered. 

        }
    }
}
