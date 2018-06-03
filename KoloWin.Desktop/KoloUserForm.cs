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
    public partial class KoloUserForm : Form
    {
        Uri KoloUri;
        KoloGateway.KoloEntities context;

        public KoloEntities Context
        {
            get
            {
                return context ?? (context = new KoloEntities(KoloUri));
            }

            set
            {
                context = value ?? new KoloEntities(KoloUri);
            }
        }

        public KoloUserForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

        private void btnCreer_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (!txtCountry.Text.Equals("") && !txtdateOfBirthDateEdit.Text.Equals("") && !txtEmail.Text.Equals("") && !txtfirstnameTextEdit.Text.Equals("") && !txtgenderCodeTextEdit.Text.Equals
               ("") && !txtlastnameTextEdit.Text.Equals("") && !txtmaritalStatusCodeTextEdit.Text.Equals("") && !txtmiddlenameTextEdit.Text.Equals("") && !txtPassword.Text.Equals("") && !txtPhone.Text.Equals("") && !txtProvince.Text.Equals("") && txtUserId.Text.Equals(""))
                {
                    var newUser = CreatekoloUsersBindingSource.Current as KoloUser;
                    if (newUser == null)
                    {
                        MessageBox.Show("veuillez recommencer");
                        CreatekoloUsersBindingSource.DataSource = new RefAddressType();
                        CreatekoloUsersBindingSource.ResetBindings(true);
                    }
                    else
                    {
                        KoloContextHelper.Context.AddToKoloUsers(newUser);
                        KoloContextHelper.Context.SaveChanges();
                        CreatekoloUsersBindingSource.ResetBindings(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KoloUserForm_Load(object sender, EventArgs e)
        {
            koloUsersBindingSource.DataSource = new KoloUser();
            var KUser = Context.KoloUsers.ToList();
            koloUsersBindingSource.DataSource = KUser;
            koloUsersBindingSource.ResetBindings(false);

            CreatekoloUsersBindingSource.DataSource = new KoloUser();
            var KCUser = Context.KoloUsers.ToList();
            CreatekoloUsersBindingSource.DataSource = KCUser;
            CreatekoloUsersBindingSource.ResetBindings(false);

            countriesBindingSource.DataSource = new Country();
            var UserCountry = Context.Countries.ToList();
            countriesBindingSource.DataSource = UserCountry;
            countriesBindingSource.ResetBindings(false);

            citiesBindingSource.DataSource = new City();
            var UserCity = Context.Cities.ToList();
            citiesBindingSource.DataSource = UserCity;
            citiesBindingSource.ResetBindings(false);

            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            

            
        }
    }
}
