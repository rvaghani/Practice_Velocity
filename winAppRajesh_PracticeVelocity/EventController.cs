using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using EventTypeModel;

namespace winAppRajesh_PracticeVelocity
{
    public class EventController
    {
        IEventTypeModel eventObj;

        public EventController()
        {
        }

        public void callHandler(int index, Form frm)
        {
            myEventArgs e = new myEventArgs(index);

            if (index == (int)EventList.Register)
            {
                eventObj = new EventRegister();
            }
            if (index == (int)EventList.Diagnose)
            {
                eventObj = new EventDiagnose();
            }
            eventObj.OnDisplayHandler(e);
                
            RichTextBox rtb = (RichTextBox)frm.Controls["rtbDashBoard"];
            rtb.Clear();
            rtb.AppendText(eventObj.DashBoardString);
        }
  }
    
    public class EventDiagnose : clsEventTypeModel
    {
        public EventDiagnose()
            : base(2, 7, "Diagnose", "Patient")
        {
            displayHandler += new EventHandler(event_DisplayDashBoard);
        }

        public void event_DisplayDashBoard(Object sender, EventArgs e)
        {
            myEventArgs myArgs = e as myEventArgs;
            if (myArgs.EventType == 1)
                
            {
                setDashBoard();
                //MessageBox.Show(DashBoardString );
            }
        }
    }

    public class EventRegister : clsEventTypeModel
    {
        public EventRegister()
            : base(3, 5, "Register", "Patient")
        {
            displayHandler += new EventHandler(event_DisplayDashBoard);
        }

        public void event_DisplayDashBoard(Object sender, EventArgs e)
        {
            myEventArgs myArgs = e as myEventArgs;
            if (myArgs.EventType == 0)
            {
                setDashBoard();
                //MessageBox.Show(DashBoardString);
            }
        }
    }

}
