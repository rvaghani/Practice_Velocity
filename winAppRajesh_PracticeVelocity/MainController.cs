using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using EventTypeModel;

namespace winAppRajesh_PracticeVelocity
{
    public class MainController
    {
        public MainController()
        { 
        }

        public DataTable populateEventTable()
        {
            DataTable dt = new DataTable("EvetList");
            dt.Columns.Add("EventItem", typeof(string));
            dt.Rows.Add(new string[] { "Register" });
            dt.Rows.Add(new string[] { "Diagnose" });
            return dt;
        }
  

        public string updateDashBoard( int et)
        {
            IEventTypeModel eventObj = null;
            if (et == (int)EventList.Register)
            {
                eventObj = new clsEventTypeModel(3, 5, "Register", "patient");
            }
            else if (et == (int)EventList.Diagnose)
            {
                eventObj = new clsEventTypeModel(2, 7, "Diagnose", "patient");
            }
            eventObj.setDashBoard();
            string displayString = eventObj.DashBoardString;
            
           return displayString;
        }
    }
}
