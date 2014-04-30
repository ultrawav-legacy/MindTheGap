using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MindTheGap
{
    public partial class ControllerForm: MetroForm
    {
        public ControllerForm()
        {
            InitializeComponent();
        }

        private void ControllerForm_Load(object sender, EventArgs e)
        {

            lblName.Text = GetCurrentUserName();

            Image UserImage = GetUserPicture(GetCurrentUser().Name);
            if(UserImage != null) {
                pictureBox1.Image = UserImage;
            }

        }

        private Image GetUserPicture(string userName)
        {
            using (DirectorySearcher dsSearcher = new DirectorySearcher())
            {
                dsSearcher.Filter = "(&(objectClass=user) (cn=" + userName + "))";
                SearchResult result = dsSearcher.FindOne();

                using (DirectoryEntry user = new DirectoryEntry(result.Path))
                {
                    byte[] data = user.Properties["thumbnailPhoto"].Value as byte[];

                    if (data != null)
                    {
                        using (MemoryStream s = new MemoryStream(data))
                        {
                            return Bitmap.FromStream(s);
                        }
                    }

                    return null;
                }
            }
        }


        private string GetCurrentUserName()
        {
            return GetCurrentUser().DisplayName;  
        }

        private UserPrincipal GetCurrentUser()
        {
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = UserPrincipal.Current;

            return user;
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

        private void metroTile7_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(ControllerForm.ActiveForm, "Do you like this metro message box?", "Metro Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }


    }
}
