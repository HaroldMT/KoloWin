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
    
    public partial class TransfertStatusForm : Form
    {
        private Uri KoloUri;
        public KoloEntities Context
        {
            get
            {
                return KoloContextHelper.Context ?? (KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri));
            }

            set
            {
                KoloContextHelper.Context = value ?? new KoloEntities(KoloUri);
            }
        }
        public TransfertStatusForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var TransferStatutToCreate = refCreateTransfertStatusBindingSource.Current as RefTransfertStatu;
                

                if (TransferStatutToCreate == null)
                {
                    MessageBox.Show("Status Matrimonial Invalide.Veuillez recommencer");
                    refCreateTransfertStatusBindingSource.DataSource = new RefTransfertStatu();
                    refCreateTransfertStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefTransfertStatus(TransferStatutToCreate);
                    refCreateTransfertStatusBindingSource.ResetBindings(false);
                    MessageBox.Show("Creer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var TransfertStatusASupprimer = refTransfertStatusBindingSource.Current as RefTransfertStatu;
                if (TransfertStatusASupprimer == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(TransfertStatusASupprimer);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refCreateTransfertStatusBindingSource.DataSource = new RefTransfertStatu();
            refCreateTransfertStatusBindingSource.ResetBindings(false);
           
            var refMaritalStatus = KoloContextHelper.Context.RefMaritalStatus.ToList();

            refTransfertStatusBindingSource.DataSource = refMaritalStatus;

            refTransfertStatusBindingSource.ResetBindings(false);

            var nb = refMaritalStatus.Count;
            MessageBox.Show(nb.ToString() + " status téléchargées");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var TransfertStatusToUpdate = refTransfertStatusBindingSource.Current as KoloEntities;
                if (TransfertStatusToUpdate == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(TransfertStatusToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistrer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransfertStatusForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
