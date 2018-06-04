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
    public partial class RefCustomerTypesForm : Form
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
    
        public RefCustomerTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

        private void RefCustomerTypesForm_Load(object sender, EventArgs e)
        {
            btnActualiser(null, null);
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnCreer(object sender, EventArgs e)
        {
            try
            {
                var customerTypeToCreate = refCreerCustomerTypesBindingSource.Current as RefCustomerType;
                if (customerTypeToCreate == null)
                {
                    MessageBox.Show("Type de client nulle invalide, veuillez recommencer");
                    refCreerCustomerTypesBindingSource.DataSource = new RefCustomerType();
                    refCreerCustomerTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefCustomerTypes(customerTypeToCreate);
                    Context.SaveChanges();
                    refCreerCustomerTypesBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var customerTypeToUpdate = refCustomerTypesBindingSource.Current as RefCustomerType;
                if (customerTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun Type de client sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(customerTypeToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Lorsqu'on clique sur le bouton actualiser
        private void btnSupprimer(object sender, EventArgs e)
        {
            try
            {
                var customerTypeToDelete = refCustomerTypesBindingSource.Current as RefCustomerType;
                if (customerTypeToDelete == null)
                {
                    MessageBox.Show("Aucun Type de client sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(customerTypeToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refCreerCustomerTypesBindingSource.DataSource = new RefCustomerType();
            refCreerCustomerTypesBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refCustomerTypes = Context.RefCustomerTypes.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refCustomerTypesBindingSource.DataSource = refCustomerTypes;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refCustomerTypesBindingSource.ResetBindings(false);

            var nb = refCustomerTypes.Count;
            MessageBox.Show(nb.ToString() + " Type de client téléchargées");
        }

    }
}
