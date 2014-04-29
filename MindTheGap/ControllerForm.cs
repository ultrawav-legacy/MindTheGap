using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindTheGap
{
    public partial class ControllerForm: MetroFramework.Forms.MetroForm
    {
        public ControllerForm()
        {
            InitializeComponent();
        }

        private void ControllerForm_Load(object sender, EventArgs e)
        {
            lblName.Text = GetCurrentUserName();

        }
        private string GetCurrentUserName()
        {
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = UserPrincipal.Current;

            return user.DisplayName;  
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

        }


    }
}
