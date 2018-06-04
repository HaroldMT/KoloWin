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
    public partial class RefLoginStatusForm : Form
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
        public RefLoginStatusForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

       

        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refCreerStatusBindingSource.DataSource = new RefLoginStatu();
            refCreerStatusBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refLoginStatus = Context.RefLoginStatus.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refLoginStatusBindingSource.DataSource = refLoginStatus;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refLoginStatusBindingSource.ResetBindings(false);

            var nb = refLoginStatus.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var loginStatusToUpdate = refLoginStatusBindingSource.Current as RefLoginStatu;
                if (loginStatusToUpdate == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(loginStatusToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuppimer(object sender, EventArgs e)
        {
            try
            {
                var loginStatusToDelete = refLoginStatusBindingSource.Current as RefLoginStatu;
                if (loginStatusToDelete == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(loginStatusToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreer(object sender, EventArgs e)
        {
            try
            {
                var loginStatusToCreate = refCreerStatusBindingSource.Current as RefLoginStatu;
                if (loginStatusToCreate == null)
                {
                    MessageBox.Show("Adresse nulle invalide, veuillez recommencer");
                    refCreerStatusBindingSource.DataSource = new RefLoginStatu();
                    refCreerStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefLoginStatus(loginStatusToCreate);
                    Context.SaveChanges();
                    refCreerStatusBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefLoginStatusForm_Load(object sender, EventArgs e)
        {
            btnActualiser(null, null);
        }
    }
}
