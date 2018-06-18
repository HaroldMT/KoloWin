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
    public partial class KoloWinInterfaceForm : Form
    {
        public KoloWinInterfaceForm() 

        {
            InitializeComponent();
        }

        private void btnGestParaRef(object sender, EventArgs e)
            
        {
            //if (dropDownBtnGestParaRef)
            //{
            //    var RefAddressTypesForm = new RefAddressTypeForm();
            //    RefAddressTypesForm.ShowDialog();
            //}
                
            //(new RefAddressTypeForm()).ShowDialog;
        }


        //{
        //    var billStatus = new RefBillStatusForm();
        //    RefBillStatusForm.ShowDialog();

    private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        //private void tileNavCategoryParametres_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        //{
        //    //e.IsTile
        //    if (e.Element == tileNavItemRefAddressType)
        //    {
        //        var refAddressTypeForm = new RefAddressTypeForm();
        //        refAddressTypeForm.ShowDialog();
        //        //(new RefAddressTypeForm()).ShowDialog();
        //     }

        //    if (e.Element == tileNavItemRefBillStatus)
        //    {
        //        var refBillStatuForm = new RefBillStatusForm();
        //        refBillStatuForm.ShowDialog();
        //        //(new RefBillStatusForm()).ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefBillTypes)
        //    {
        //        var refBillTypeForm = new RefBillTypesForm();
        //        refBillTypeForm.ShowDialog();
        //        //(new RefBillTypesForm()).ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefCustomerTypes)
        //    {
        //        var refCustomerTypeForm = new RefCustomerTypesForm();
        //        refCustomerTypeForm.ShowDialog();
        //        //(new RefCustomerTypesForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefExternalAccountTypes)
        //    {
        //        var refExternalAccountTypeForm = new RefExternalAccountTypesForm();
        //        refExternalAccountTypeForm.ShowDialog();
        //        //(new RefExternalAccountTypesForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefGenders)
        //    {
        //        var refGenderForm = new RefGendersForm();
        //        refGenderForm.ShowDialog();
        //        //(new RefGendersForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefGroupTypes)
        //    {
        //        var refGroupTypeForm = new RefGroupTypesForm();
        //        refGroupTypeForm.ShowDialog();
        //        //(new RefGroupTypesForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefIndustryCategories)
        //    {
        //        var refIndustryCategoriesForm = new RefIndustryCategoriesForm();
        //        refIndustryCategoriesForm.ShowDialog();
        //        //(new RefIndustryCategoriesForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefLoginStatus)
        //    {
        //        var refLoginStatuForm = new RefLoginStatusForm();
        //        refLoginStatuForm.ShowDialog();
        //        //(new RefLoginStatusForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefMaritalStatus)
        //    {
        //        var refMaritalStatuForm = new RefMaritalStatusTypeForm();
        //        refMaritalStatuForm.ShowDialog();
        //        //(new RefMaritalStatusForm()).Show \Dialog();
        //    }

        //    if (e.Element == tileNavItemRefOperationStatus)
        //    {
        //        var refOperationStatuForm = new RefOperationStatusForm();
        //        refOperationStatuForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefOperationTypes)
        //    {
        //        var refOperationTypeForm = new RefOperationTypesForm();
        //        refOperationTypeForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefPartnerTypes)
        //    {
        //        var refPartnerTypeForm = new RefPartnerTypesForm();
        //        refPartnerTypeForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefPersonRelationshipTypes)
        //    {
        //        var refPersonRelationshipTypeForm = new RefPersonRelationshipTypesForm();
        //        refPersonRelationshipTypeForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefProvisionStatus)
        //    {
        //        var refProvisionStatuForm = new RefProvisionStatusForm();
        //        refProvisionStatuForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemRefRegistratinStatus)
        //    {
        //        var refRefgistratinStatuForm = new RefRegistratinStatusForm();
        //        refRefgistratinStatuForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemResults)
        //    {
        //        var ResultForm = new ResultsForm();
        //        ResultForm.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemTransfertStatus)
        //    {
        //        var TransfertStatuForm = new TransfertStatusForm();
        //        TransfertStatuForm.ShowDialog();
        //    }
        //}

        //private void tileNavCategoryAdresses_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        //{
        //     {
        //        List<string> Pays = new List<string>();
        //         if (e.Element == tileNavItemPays)
        //            var Pays = new Pays();
        //            Region.showDialog();
        //     }

        //    {
        //        List<string> Regions = new List<string>();
        //        if (e.Element == tileNavItemRegions)
        //            var Region = new Regions();
        //            Region.ShowDialog();    
        //    }

        //    {
        //        List<string> Departements = new List<string>();
        //        if (e.Element == tileNavItemDepartements)
        //            var Departement = new Departements();
        //            Departement.ShowDialog();
        //    }

        //    {
        //        List<string> Arrondissements = new List<string>();
        //        if (e.Element == tileNavItemArrondissements)
        //            var Arrondissement = new Arrondissiments();
        //            Arrondissement.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemDistricts)
        //    {
        //        var District = new Districts();
        //        District.ShowDialog();
        //    }

        //    if (e.Element == tileNavItemVilles)
        //        Ville.ShowDialog();
    }

        //private void navKoloWinElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        
    
