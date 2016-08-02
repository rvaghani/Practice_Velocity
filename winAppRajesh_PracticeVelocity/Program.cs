using System;
using System.Windows.Forms;

namespace winAppRajesh_PracticeVelocity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainController mainController;
            frmDashBoardView objDashBoardView;
            try
            {
                mainController = new MainController();
                objDashBoardView = new frmDashBoardView(mainController);
                objDashBoardView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                mainController = null;
                objDashBoardView = null;
            }
        }
    }
}
