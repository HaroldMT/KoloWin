using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KoloWin.Desktop.KoloGateway;

namespace KoloWin.Desktop
{
    public partial class RecoveryCustomerLoginForm : Form
    {
        public RecoveryCustomerLoginForm()
        {
            InitializeComponent();
        }

        
        private void BtnSeconnecter_Click(object sender, EventArgs e)
        {
            string user = textEditAdresseemail.Text;
            string pwd = textEditMotdepasse.Text;
            string emailID = textEditAdresseemail.Text;

            if(pwd != null)
            {
                if (user != null)
                {
                    var kUser = new KoloUser();
                    kUser.EmailAddress = user;
                    kUser.Pwd = pwd;
                    MessageBox.Show("Reussi!");
                   
                      
                }
            }
           

            }

        }
    }

