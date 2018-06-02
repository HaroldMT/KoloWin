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
    public partial class RefMaritalStatusTypeForm : Form
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

        public RefMaritalStatusTypeForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
           
        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                var MaritalStatutToCreate = refCreateMaritalStatusBindingSource.Current as RefMaritalStatu;
               

                if (MaritalStatutToCreate == null)
                {
                    MessageBox.Show("Status Matrimonial Invalide.Veuillez recommencer");
                    refCreateMaritalStatusBindingSource.DataSource = new RefMaritalStatu();
                    refCreateMaritalStatusBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefMaritalStatus(MaritalStatutToCreate);
                    Context.SaveChanges();
                    refCreateMaritalStatusBindingSource.ResetBindings(false);
                    MessageBox.Show("Effectuer avec success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var StatutMaritalASupprimer = refMaritalStatusBindingSource.Current as RefMaritalStatu;
                if (StatutMaritalASupprimer == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    KoloContextHelper.Context.DeleteObject(StatutMaritalASupprimer);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Supprimer");
                   
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            refCreateMaritalStatusBindingSource.DataSource = new RefMaritalStatu();
            refCreateMaritalStatusBindingSource.ResetBindings(false);

            var refMaritalStatus = KoloContextHelper.Context.RefMaritalStatus.ToList();

            refMaritalStatusBindingSource.DataSource = refMaritalStatus;

            refMaritalStatusBindingSource.ResetBindings(false);

            var nb = refMaritalStatus.Count;
            MessageBox.Show(nb.ToString() + " adresses téléchargées");

        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                var MaritalStatusToUpdate = refMaritalStatusBindingSource.Current as RefMaritalStatu;
               
                if (MaritalStatusToUpdate == null)
                {
                    MessageBox.Show("Aucun statut matrimonial sélectionnée, l'opération ne peut continuer");

                }
                else
                {
                    KoloContextHelper.Context.UpdateObject(MaritalStatusToUpdate);
                    KoloContextHelper.Context.SaveChanges();
                    MessageBox.Show("Enrergistrer");
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefMaritalStatusTypeForm_Load(object sender, EventArgs e)
        {
           BtnActualiser_Click(null, null);
        }
    }
 }


