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
    public partial class RefPartnerTypesForm : Form
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
        public RefPartnerTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var PartnerTypeToCreate = refCreatePartnerTypesBindingSource.Current as RefPartnerType;
                

                if (PartnerTypeToCreate == null)
                {
                    MessageBox.Show("Type De Partenaire Invalide.Veuillez recommencer");
                    refCreatePartnerTypesBindingSource.DataSource = new RefPartnerType();
                    refCreatePartnerTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefPartnerTypes(PartnerTypeToCreate);
                    KoloContextHelper.Context.SaveChanges();
                    refCreatePartnerTypesBindingSource.ResetBindings(false);
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
                var PartnerTypeASupprimer = refPartnerTypesBindingSource.Current as RefPartnerType;
                if (PartnerTypeASupprimer == null)
                {
                    MessageBox.Show("Aucune type sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(PartnerTypeASupprimer);
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
            refCreatePartnerTypesBindingSource.DataSource = new RefPartnerType();
            refCreatePartnerTypesBindingSource.ResetBindings(false);

            //KoloContextHelper.Context = new KoloGateway.KoloEntities(KoloUri);

            var refPartnerType = KoloContextHelper.Context.RefPartnerTypes.ToList();
            refPartnerTypesBindingSource.DataSource = refPartnerType;

            refPartnerTypesBindingSource.ResetBindings(false);

            var nb = refPartnerType.Count;
            MessageBox.Show(nb.ToString() + " types téléchargées");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var PartnerTypeToUpdate = new RefPartnerType();
                if (PartnerTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(PartnerTypeToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Mise a jour effectueer avec success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void RefPartnerTypesForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
 }

