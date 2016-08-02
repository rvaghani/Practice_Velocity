using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winAppRajesh_PracticeVelocity
{
    public partial class frmDashBoardView : Form
    {
        private MainController _mainController;
        
        public frmDashBoardView(MainController mainContoller)
        {
            InitializeComponent();
            _mainController = mainContoller;
        }

        private void frmDashBoardView_Load(object sender, EventArgs e)
        {
            DataTable dtSource = _mainController.populateEventTable();
            cmbEventType.DataSource = dtSource;
            cmbEventType.DisplayMember =  dtSource.Columns[0].Caption;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            handleRunClick();
        }

        private void handleRunClick()
        {
            rtbDashBoard.Clear();
            string displayString = _mainController.updateDashBoard(cmbEventType.SelectedIndex);
            rtbDashBoard.AppendText(displayString);
            Application.DoEvents();
        }

        private void btnEventRun_Click(object sender, EventArgs e)
        {
            int et = cmbEventType.SelectedIndex;
            EventController ec = new EventController();
            ec.callHandler(et, this);           
        }
    }
}
