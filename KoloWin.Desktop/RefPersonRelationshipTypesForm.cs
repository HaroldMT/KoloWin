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
    public partial class RefPersonRelationshipTypesForm : Form
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


        public RefPersonRelationshipTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           try
            {
                var PersonalRelationshipToCreate = refCreatePersonRelationshipTypesBindingSource.Current as RefPersonRelationshipType;
               

                if (PersonalRelationshipToCreate == null)
                {
                    MessageBox.Show("Detail Invalide.Veuillez recommencer");
                    refCreatePersonRelationshipTypesBindingSource.DataSource = new RefMaritalStatu();
                    refCreatePersonRelationshipTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    KoloContextHelper.Context.AddToRefPersonRelationshipTypes(PersonalRelationshipToCreate);
                    refCreatePersonRelationshipTypesBindingSource.ResetBindings(false);
                    MessageBox.Show("Creer Avec Success");
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
                var PersonRelationshipTypeASupprimer = refPersonRelationshipTypesBindingSource.Current as RefPersonRelationshipType;

                if (PersonRelationshipTypeASupprimer == null)
                {
                    MessageBox.Show("Aucun type sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(PersonRelationshipTypeASupprimer);
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
            refCreatePersonRelationshipTypesBindingSource.DataSource = new RefPersonRelationshipType();
            refCreatePersonRelationshipTypesBindingSource.ResetBindings(false);

            var refPersonRelationshipType = KoloContextHelper.Context.RefPersonRelationshipTypes.ToList();

            refPersonRelationshipTypesBindingSource.DataSource = refPersonRelationshipType;

            refPersonRelationshipTypesBindingSource.ResetBindings(false);

            var nb = refPersonRelationshipType.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var PersonRelationsTypeToUpdate = refPersonRelationshipTypesBindingSource.Current as KoloEntities;
                if (PersonRelationsTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(PersonRelationsTypeToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefPersonRelationshipTypesForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
    }
}
