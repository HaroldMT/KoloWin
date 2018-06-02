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
    public partial class RefGroupTypesForm : Form
    {
        Uri KoloUri;
        KoloGateway.KoloEntities Context;

        public KoloEntities context
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
        public RefGroupTypesForm()
        {
            InitializeComponent();
            KoloUri = KoloContextHelper.KoloUri;
        }
        private void btnActualiser(object sender, EventArgs e)
        {
            //Créer un nouveau RefAddressType et le lier à la source de données, qui sera utilisée pour la création
            refCreerGroupTypesBindingSource.DataSource = new RefGroupType();
            refCreerGroupTypesBindingSource.ResetBindings(false);

            //Création du proxy du service
            Context = new KoloGateway.KoloEntities(KoloUri);

            //Téléchargement de tous les types d'adresses
            var refGroupTypes = Context.RefGroupTypes.ToList();

            //Liaison du BindingSource avec la liste d'adresses téléchargées
            refGroupTypesBindingSource.DataSource = refGroupTypes;

            //Actualiser les contrôles liés au BindingSource (false veut dire qu'on ne recrée pas le schéma de présentation)
            refGroupTypesBindingSource.ResetBindings(false);

            var nb = refGroupTypes.Count;
            MessageBox.Show(nb.ToString() + " type de groupe téléchargés");
        }

        private void btnEnregistrer(object sender, EventArgs e)
        {
            try
            {
                var groupTypeToUpdate = refGroupTypesBindingSource.Current as RefGroupType;
                if (groupTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type de groupe sélectionnée, l'opération ne peut continuer");
                }
                else
                {
                    Context.UpdateObject(groupTypeToUpdate);
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
                var groupTypeToUpdate = refGroupTypesBindingSource.Current as RefGroupType;
                if (groupTypeToUpdate == null)
                {
                    MessageBox.Show("Aucun type de groupe sélectionné, l'opération ne peut continuer");
                }
                else
                {
                    Context.DeleteObject(groupTypeToUpdate);
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
                var groupTypeToCreate = refCreerGroupTypesBindingSource.Current as RefGroupType;
                if (groupTypeToCreate == null)
                {
                    MessageBox.Show("Type de groupe nulle invalide, veuillez recommencer");
                    refCreerGroupTypesBindingSource.DataSource = new RefGroupType();
                    refCreerGroupTypesBindingSource.ResetBindings(true);
                }
                else
                {
                    Context.AddToRefGroupTypes(groupTypeToCreate);
                    Context.SaveChanges();
                    refCreerGroupTypesBindingSource.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
