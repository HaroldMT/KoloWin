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
    public partial class RefBillTypesForm : Form
    {
        Uri KoloUri;
        KoloGateway.KoloEntities Context;

        public KoloEntities context;
        
        
        public RefBillTypesForm()
        { 
                InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

        private void RefBillTypesForm_Load(object sender, EventArgs e)
        {
            btnActualiser(null, null);
        }

        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refCreerBillTypesBindingSource.DataSource = new RefBillType();
            refCreerBillTypesBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var RefBillType = Context.RefBillTypes.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refBillTypesBindingSource.DataSource = RefBillType;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refBillTypesBindingSource.ResetBindings(false);

            var nb = RefBillType.Count;
            MessageBox.Show(nb.ToString() + " type de facture téléchargées");
        }

        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var billTypeToUpdate = refBillTypesBindingSource.Current as RefBillType;
                if (billTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type de facture sélectionné, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(billTypeToUpdate);
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
                var billTypeToUpdate = refBillTypesBindingSource.Current as RefBillType;
                if (billTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type de facture sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(billTypeToUpdate);
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
                var billTypeToCreate = refCreerBillTypesBindingSource.Current as RefBillType;
                if (billTypeToCreate == null)
                {
                    MessageBox.Show("Type de facture nulle invalide, veuillez recommencer");
                    refCreerBillTypesBindingSource.DataSource = new RefBillType();
                    refCreerBillTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefBillTypes(billTypeToCreate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
