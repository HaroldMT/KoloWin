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
    public partial class RefIndustryCategoriesForm : Form
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

        public object RefIndustryCategories { get; private set; }

        public RefIndustryCategoriesForm()
        {
            InitializeComponent();
            KoloUri = new Uri("http://192.168.1.10/KoloWin.Web/KoloWcfService.svc/");
        }

        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refIndustryCategoriesBindingSource.DataSource = new RefIndustryCategory();
            refIndustryCategoriesBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refAdressTypes = Context.RefIndustryCategories.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refIndustryCategoriesBindingSource.DataSource = RefIndustryCategories;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refIndustryCategoriesBindingSource.ResetBindings(false);
        }

        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var industryCategorieToUpdate = refIndustryCategoriesBindingSource.Current as RefIndustryCategory;
                if (industryCategorieToUpdate == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(industryCategorieToUpdate);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer(object sender, EventArgs e)
        {
            try
            {
                var industryCategoriesToDelete = refIndustryCategoriesBindingSource.Current as RefIndustryCategory;
                if (industryCategoriesToDelete == null)
                {
                    MessageBox.Show("Aucune adresse sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(industryCategoriesToDelete);
                    Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreer(object sender, EventArgs e)
        {
            try
            {
                var industryCategoriesToCreate = refCreerIndustryBindingSource.Current as RefIndustryCategory;
                if (industryCategoriesToCreate == null)
                {
                    MessageBox.Show("Adresse nulle invalide, veuillez recommencer");
                    refCreerIndustryBindingSource.DataSource = new RefIndustryCategory();
                    refCreerIndustryBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefIndustryCategories(industryCategoriesToCreate);
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
