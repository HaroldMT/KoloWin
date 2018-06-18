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
                var userFound = KoloContextHelper.Context.KoloUsers
                    .Where(koloUser => koloUser.UserLogin == user & koloUser.Pwd == pwd).ToList().FirstOrDefault();
                var isValidUser = userFound != null;
                //Quand on entre le nom de l'identifiant et le mot de passe correct
                if (isValidUser == true)
                {
                    new KoloWinInterfaceForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mot de passe ou nom de l'utilisateur incorrect, veillez recommencer");
                }


                koloUsersBindingSource.DataSource = new CustomerLoginForm2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void Motdepasseoublié(object sender, EventArgs e)
        {
            new RecoveryCustomerLoginForm().ShowDialog();

       
        }

        //private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void checkSesouvenir(object sender, EventArgs e)
        //{
        //    if (checkEditSesouvenir.Checked)
        //    {
        //      textEditMotdePasse() = "true";
        //    }
        //     else
        //    {
        //        textEditMotdePasse.Text() = "false";
        //    }
        //}


    }
    }
