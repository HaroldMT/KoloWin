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
    public partial class RefBillStatusForm : Form
    {
        private Uri KoloUri;
        private KoloEntities context;

        public KoloEntities Context
        {
            get
            {

                return context ?? (context = new KoloEntities(KoloUri));
            }

            set
            {

                context = value ?? new KoloEntities(KoloUri);

                InitializeComponent();
                KoloUri = new Uri("http://192.168.1.168/KoloWin.Web/KoloWcfService.svc/");
            }

        }

        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refBillStatusBindingSource.DataSource = new RefBillStatu();
            refBillStatusBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var RefBillStatus = Context.RefBillStatus.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refBillStatusBindingSource.DataSource = RefBillStatus;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refBillStatusBindingSource.ResetBindings(false);

            var nb = RefBillStatus.Count;
            MessageBox.Show(nb.ToString() + " facture téléchargées");
        }

        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var billStatusToUpdate = refBillStatusBindingSource.Current as RefBillStatu;
                if (billStatusToUpdate == null)
                {
                    MessageBox.Show("Aucune facture sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(billStatusToUpdate);
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
                var billStatusToDelete = refBillStatusBindingSource.Current as RefBillStatu;
                if (billStatusToDelete == null)
                {
                    MessageBox.Show("Aucune facture sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(billStatusToDelete);
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
                var billStatusToCreate = RefCreerBillStatusBindingSource.Current as RefBillStatu;
                if (billStatusToCreate == null)
                {
                    MessageBox.Show("Statut de facture nulle invalide, veuillez recommencer");
                    RefCreerBillStatusBindingSource.DataSource = new RefBillStatu();
                    RefCreerBillStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefBillStatus(billStatusToCreate);
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