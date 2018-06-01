using System;
using System.Linq;
using System.Windows.Forms;
using KoloWin.Desktop.KoloGateway;

namespace KoloWin.Desktop
{
    public partial class RefAddressTypeForm : Form
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

        public RefAddressTypeForm()
        {
            InitializeComponent();
            KoloUri = new Uri("http://192.168.1.10/KoloWin.Web/KoloWcfService.svc/");
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var addressTypeToCreate = refCreateAddressTypesBindingSource.Current as RefAddressType;
                if (addressTypeToCreate == null)
                {
                    MessageBox.Show("Adresse nulle invalide, veuillez recommencer");
                    refCreateAddressTypesBindingSource.DataSource = new RefAddressType();
                    refCreateAddressTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefAddressTypes(addressTypeToCreate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var addressTypeToDelete = refAddressTypesBindingSource.Current as RefAddressType;
                if (addressTypeToDelete == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(addressTypeToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refCreateAddressTypesBindingSource.DataSource = new RefAddressType();
            refCreateAddressTypesBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refAdressTypes = Context.RefAddressTypes.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refAddressTypesBindingSource.DataSource = refAdressTypes;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refAddressTypesBindingSource.ResetBindings(false);

            var nb = refAdressTypes.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var addressTypeToUpdate = refAddressTypesBindingSource.Current as RefAddressType;
                if (addressTypeToUpdate == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(addressTypeToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cette méthode s'exécute lorsque la page s'affiche (lorsque le chargement est terminé)
        private void RefAddressTypeForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}