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
    

    public partial class RefOperationStatusForm : Form
    {
        Uri KoloUri;

    public KoloEntities Context
        {
            get
            {
                return KoloContextHelper.Context ?? (KoloContextHelper.Context = new KoloGateway.KoloEntities
                    (KoloUri));
            }

            set
            {
                KoloContextHelper.Context = value ?? new KoloEntities(KoloUri);
            }
        }
        
        public RefOperationStatusForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                var OperationStatusToCreate = refCreateOperationStatusBindingSource.Current as RefOperationStatu;
               
                if (OperationStatusToCreate == null)
                {
                    MessageBox.Show("Status D'Operation Invalide.Veuillez recommencer");
                    refCreateOperationStatusBindingSource.DataSource = new RefOperationStatu();
                    refCreateOperationStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefOperationStatus(OperationStatusToCreate);
                    KoloContextHelper.Context.SaveChanges();
                    refCreateOperationStatusBindingSource.ResetBindings(false);
                    MessageBox.Show("Creer avec success!");
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
                var StatutOperationASupprimer = refOperationStatusBindingSource.Current as RefOperationStatu;
                if(StatutOperationASupprimer == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(StatutOperationASupprimer);
                    KoloContextHelper.Context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refCreateOperationStatusBindingSource.DataSource = new RefOperationStatu();
            refCreateOperationStatusBindingSource.ResetBindings(false);
            

            var refOperationStatus = KoloContextHelper.Context.RefOperationStatus.ToList();

            refOperationStatusBindingSource.DataSource = refOperationStatus;

            refOperationStatusBindingSource.ResetBindings(false);

            var nb = refOperationStatus.Count;
            MessageBox.Show(nb.ToString() + " operation(s) Telecharges");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var OperationStatusToUpdate = refOperationStatusBindingSource.Current as RefOperationStatu;
                
                if (OperationStatusToUpdate == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(OperationStatusToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistrer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefOperationStatusForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
