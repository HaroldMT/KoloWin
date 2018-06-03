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
    
    public partial class RefProvisionStatusForm : Form
    {
        public Uri KoloUri;
        
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

        public RefProvisionStatusForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //var ProvisionStatusToCreate = refProvisionStatusBindingSource.Current as RefProvisionStatu;
                var ProvisionStatusToCreate = new RefProvisionStatu();
                
                if (ProvisionStatusToCreate == null)
                {
                    MessageBox.Show("Status Invalide.Veuillez recommencer");
                    refCreateProvisionStatusBindingSource.DataSource = new RefProvisionStatu();
                    refCreateProvisionStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefProvisionStatus(ProvisionStatusToCreate);
                    KoloContextHelper.Context.SaveChanges();
                    refCreateProvisionStatusBindingSource.ResetBindings(false);
                    MessageBox.Show("Creer avec success");
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
                var ProvisionStatusASupprimer = refProvisionStatusBindingSource.Current as RefProvisionStatu;
                if (ProvisionStatusASupprimer == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(ProvisionStatusASupprimer);
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
            refCreateProvisionStatusBindingSource.DataSource = new RefMaritalStatu();
            refCreateProvisionStatusBindingSource.ResetBindings(false);

            var refProvisionStatus = KoloContextHelper.Context.RefProvisionStatus.ToList();

            refProvisionStatusBindingSource.DataSource = refProvisionStatus;

            refProvisionStatusBindingSource.ResetBindings(false);

            var nb = refProvisionStatus.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ProvisionStatusToUpdate = refProvisionStatusBindingSource.Current as RefProvisionStatu;
                
              
                if (ProvisionStatusToUpdate == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(ProvisionStatusToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistrer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefProvisionStatusForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
