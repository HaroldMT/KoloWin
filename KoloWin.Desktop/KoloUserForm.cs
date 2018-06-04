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
            //CreatekoloUsersBindingSource.DataSource = new KoloUser();
            //CreatekoloUsersBindingSource.ResetBindings(false);

            try
            {
                var newUser = CreatekoloUsersBindingSource.Current as KoloUser;
                
                
                
                if (newUser == null)
                {
                    MessageBox.Show("veuillez remplir tous les case");
                    CreatekoloUsersBindingSource.DataSource = new KoloUser();
                    CreatekoloUsersBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToKoloUsers(newUser);
                    KoloContextHelper.Context.SaveChanges();
                    CreatekoloUsersBindingSource.ResetBindings(false);
                    MessageBox.Show("Created");
                }

            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KoloUserForm_Load(object sender, EventArgs e)
        {
            var koloUser = new KoloUser()
            {
                Person = new Person()
            };

            var koloUser1 = new KoloUser();
            koloUser1.Person = new Person();


            koloUsersBindingSource.DataSource = koloUser;
            koloUsersBindingSource.ResetBindings(false);

            CreatekoloUsersBindingSource.DataSource = koloUser1;
            CreatekoloUsersBindingSource.ResetBindings(false);

            countriesBindingSource.DataSource = new Country();
            var UserCountry = Context.Countries.ToList();
            countriesBindingSource.DataSource = UserCountry;
            countriesBindingSource.ResetBindings(false);

            citiesBindingSource.DataSource = new City();
            var UserCity = Context.Cities.ToList();
            citiesBindingSource.DataSource = UserCity;
            citiesBindingSource.ResetBindings(false);

            refGendersBindingSource.DataSource = new RefGender();
            var UserGender = Context.RefGenders.ToList();
            refGendersBindingSource.DataSource = UserGender;
            refGendersBindingSource.ResetBindings(false);

            refMaritalStatusBindingSource.DataSource = new RefMaritalStatu();
            var UserMaritalStatus = Context.RefMaritalStatus.ToList();
            refMaritalStatusBindingSource.DataSource = UserMaritalStatus;
            refMaritalStatusBindingSource.ResetBindings(false);


            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            koloUsersBindingSource.DataSource = new RefAddressType();
            koloUsersBindingSource.ResetBindings(false);

            //Création du proxy du service
            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var KoloUsers = Context.KoloUsers.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            koloUsersBindingSource.DataSource = KoloUsers;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            koloUsersBindingSource.ResetBindings(false);

            var nb = KoloUsers.Count;
            MessageBox.Show(nb.ToString() + " téléchargées");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var newUser = koloUsersBindingSource.Current as KoloUser;



                if (newUser == null)
                {
                    MessageBox.Show("veuillez remplir tous les case");
                    CreatekoloUsersBindingSource.DataSource = new KoloUser();
                    CreatekoloUsersBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToKoloUsers(newUser);
                    KoloContextHelper.Context.SaveChanges();
                    CreatekoloUsersBindingSource.ResetBindings(false);
                    MessageBox.Show("Created");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
