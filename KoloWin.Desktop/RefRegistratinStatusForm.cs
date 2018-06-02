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
    public partial class RefRegistratinStatusForm : Form
    {
        private Uri KoloUri;
        //private KoloEntities context;

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

        public RefRegistratinStatusForm()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {try
            {
                var RegistrationStatusToCreate = refCreateRegistrationStatusBindingSource.Current as RefRegistrationStatu;
                RegistrationStatusToCreate.RegistrationStatusCode = txtregistrationStatusCodeTextEdit1.Text;
                RegistrationStatusToCreate.RegistrationStatusDescription = txtregistrationStatusDescriptionTextEdit1.Text;
                if (RegistrationStatusToCreate == null)
                {
                    MessageBox.Show("Status Invalide.Veuillez recommencer");
                    refCreateRegistrationStatusBindingSource.DataSource = new RefMaritalStatu();
                    refCreateRegistrationStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefRegistrationStatus(RegistrationStatusToCreate);
                    refCreateRegistrationStatusBindingSource.ResetBindings(false);
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
                var RegistrationStatutASupprimer = refRegistrationStatusBindingSource.Current as RefRegistrationStatu;
                if (RegistrationStatutASupprimer == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(RegistrationStatutASupprimer);
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
            refCreateRegistrationStatusBindingSource.DataSource = new RefRegistrationStatu();

            refCreateRegistrationStatusBindingSource.ResetBindings(false);

            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            var refRegistrationStatus = KoloContextHelper.Context.RefRegistrationStatus.ToList();

            refRegistrationStatusBindingSource.DataSource = refRegistrationStatus;

            refRegistrationStatusBindingSource.ResetBindings(false);

            var nb = refRegistrationStatus.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var RegistrationStatusToUpdate = refRegistrationStatusBindingSource.Current as RefRegistratinStatusForm;
                if (RegistrationStatusToUpdate == null)
                {
                    MessageBox.Show("Aucun statut sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(RegistrationStatusToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefRegistratinStatusForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
