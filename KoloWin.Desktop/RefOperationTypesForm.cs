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
    public partial class RefOperationTypesForm : Form
    {
        Uri KoloUri;
        

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
        public RefOperationTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
            
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                var OperationTypeToCreate = refCreateOperationTypesBindingSource.Current as RefOperationType;
                

                if (OperationTypeToCreate == null)
                {
                    MessageBox.Show("Type D'operation Invalide.Veuillez recommencer");
                    refCreateOperationTypesBindingSource.DataSource = new RefOperationType();
                    refCreateOperationTypesBindingSource.ResetBindings(true);
          
                }
                else
                {
                    KoloContextHelper.Context.AddToRefOperationTypes(OperationTypeToCreate);
                    KoloContextHelper.Context.SaveChanges();
                    refCreateOperationTypesBindingSource.ResetBindings(false);
                    MessageBox.Show("Effectuer avec success!");
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
                var OperationTypeASupprimer = refCreateOperationTypesBindingSource.Current as RefOperationType;
                if (OperationTypeASupprimer == null)
                {
                    MessageBox.Show("Aucun type sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(OperationTypeASupprimer);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Supprimer avec success!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refCreateOperationTypesBindingSource.DataSource = new RefOperationType();
            refCreateOperationTypesBindingSource.ResetBindings(false);

            var refOperationType = KoloContextHelper.Context.RefOperationTypes.ToList();

            refOperationTypesBindingSource.DataSource = refOperationType;

            refOperationTypesBindingSource.ResetBindings(false);

            var nb = refOperationType.Count;
            MessageBox.Show(nb.ToString() + " operation(s) téléchargées");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var OperationTypeToCreate = refOperationTypesBindingSource.Current as RefOperationType;

                if (OperationTypeToCreate == null)
                {
                    MessageBox.Show("Aucun type sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(OperationTypeToCreate);
                    KoloContextHelper.Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefOperationTypesForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
