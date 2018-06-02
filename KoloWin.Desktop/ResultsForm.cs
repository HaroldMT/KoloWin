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
    public partial class ResultsForm : Form
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
        public ResultsForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var ResultsToCreate = refCreateResultsBindingSource.Current as RefResult;
                ResultsToCreate.ResultCode = txtresultCodeTextEdit1.Text;
                ResultsToCreate.ResultDescription = txtresultDescriptionTextEdit1.Text;

                if (ResultsToCreate == null)
                {
                    MessageBox.Show("Saisie Invalide.Veuillez recommencer");
                    refCreateResultsBindingSource.DataSource = new RefResult();
                    refCreateResultsBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefResults(ResultsToCreate);
                    KoloContextHelper.Context.SaveChanges();
                    refCreateResultsBindingSource.ResetBindings(false);
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
                var ResultsASupprimer = refResultsBindingSource.Current as RefResult;
                if (ResultsASupprimer == null)
                {
                    MessageBox.Show("Aucun resultat sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(ResultsASupprimer);
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
            refCreateResultsBindingSource.DataSource = new RefResult();
            refCreateResultsBindingSource.ResetBindings(false);

            KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            var refResults = KoloContextHelper.Context.RefResults.ToList();

            refResultsBindingSource.DataSource = refResults;

            refResultsBindingSource.ResetBindings(false);

            var nb = refResults.Count;
            MessageBox.Show(nb.ToString() + " resultats téléchargées");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ResultsToUpdate = refResultsBindingSource.Current as KoloEntities;
                if (ResultsToUpdate == null)
                {
                    MessageBox.Show("Aucun resultat sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(ResultsToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistrer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
