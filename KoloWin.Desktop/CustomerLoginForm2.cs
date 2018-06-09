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
    public partial class CustomerLoginForm2 : Form
    {
        public CustomerLoginForm2()
        {
            InitializeComponent();

        }

        private void BtnSortir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeconnecter(object sender, EventArgs e)
        {
            string user = textEditNomdelutilisateur.Text;
            string pwd = textEditMotdePasse.Text;

            try
            {
                //Quand on entre le nom de l'identifiant et le mot de passe correct
                var customerToLogin = new KoloUser();
                if (customerToLogin == null)
                {
                    MessageBox.Show("mot de passe ou nom de l'utilisateur incorrect, veillez recommencer");

                }
                else
                {
                }


                koloUsersBindingSource.DataSource = new CustomerLoginForm2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    }

