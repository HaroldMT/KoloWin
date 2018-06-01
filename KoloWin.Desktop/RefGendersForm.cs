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
    public partial class RefGendersForm : Form
    {
        Uri KoloUri;
        KoloGateway.KoloEntities context;

        public KoloEntities Context
        {
            get
            {
                return context ?? (context = new KoloEntities(KoloUri));
            }

            set
            {
                context = value ?? new KoloEntities(KoloUri);
            }
        }
                public RefGendersForm()
        {
            InitializeComponent();
            KoloUri = new Uri("http://192.168.1.10/KoloWin.Web/KoloWcfService.svc/");
        }

        private void RefGendersForm_Load(object sender, EventArgs e)
        {

        }

        private void refGendersGridControl_Click(object sender, EventArgs e)
        {

        }
        //Lorsqu'on clique sur le bouton actualiser
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refGendersBindingSource.DataSource = new RefGender();
            refGendersBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refGender = Context.RefGenders.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refGendersBindingSource.DataSource = refGender;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refGendersBindingSource.ResetBindings(false);

            var nb = refGender.Count;
            MessageBox.Show(nb.ToString() + "genre téléchargées");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                var genderToUpdate = refGendersBindingSource.Current as RefGender;
                if (genderToUpdate == null)
                {
                    MessageBox.Show("Aucun genre sélectionné, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(genderToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                var genderToDelete = refGendersBindingSource.Current as RefGender;
                if (genderToDelete == null)
                {
                    MessageBox.Show("Aucune genre sélectionné, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(genderToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                var genderToCreate = RefGenderCreerbindingSource.Current as RefGender;
                if (genderToCreate == null)
                {
                    MessageBox.Show("Genre nulle invalide, veuillez recommencer");
                    RefGenderCreerbindingSource.DataSource = new RefGender();
                    RefGenderCreerbindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefGenders(genderToCreate);
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
        
 