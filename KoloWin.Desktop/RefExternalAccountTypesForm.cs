using KoloWin.Desktop.KoloGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoloWin.Desktop
{
    public partial class RefExternalAccountTypesForm : Form
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
        public RefExternalAccountTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            RefCreerExternalAccountBindingSource.DataSource = new RefAddressType();
            RefCreerExternalAccountBindingSource.ResetBindings(false);

            //Création du proxy du service
            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refExternalAccountType = Context.RefExternalAccountTypes.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refExternalAccountTypesBindingSource.DataSource = refExternalAccountType;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refExternalAccountTypesBindingSource.ResetBindings(false);

            var nb = refExternalAccountType.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var externalAccountTypeToUpdate = RefCreerExternalAccountBindingSource.Current as RefExternalAccountType;
                if (externalAccountTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type de compte externe sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(externalAccountTypeToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer(object sender, EventArgs e)
        {
            try
            {
                var externalAccountTypeToDelete = refExternalAccountTypesBindingSource.Current as RefExternalAccountType;
                if (externalAccountTypeToDelete == null)
                {
                    MessageBox.Show("Aucun type de compte externe sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(externalAccountTypeToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnCreer(object sender, EventArgs e)
        {
            try
            {
                var externalAccountType = RefCreerExternalAccountBindingSource.Current as RefAddressType;
                if (externalAccountType == null)
                {
                    MessageBox.Show("Adresse nulle invalide, veuillez recommencer");
                    RefCreerExternalAccountBindingSource.DataSource = new RefAddressType();
                    RefCreerExternalAccountBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefAddressTypes(externalAccountType);
                    KoloContextHelper.Context.SaveChanges();
                    RefCreerExternalAccountBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
