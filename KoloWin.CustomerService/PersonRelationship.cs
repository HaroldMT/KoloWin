//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KoloWin.CustomerService
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class PersonRelationship
    {
        public int IdCustomer { get; set; }
        public int IdPersonRelation { get; set; }
        public string RelationshipTypeCode { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Person Person1 { get; set; }
        public virtual RefPersonRelationshipType RefPersonRelationshipType { get; set; }
    }
}
