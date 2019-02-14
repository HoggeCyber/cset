//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer_Questions
    {
        public int Answer_Id { get; set; }
        public int Assessment_Id { get; set; }
        public Nullable<bool> Mark_For_Review { get; set; }
        public string Comment { get; set; }
        public string Alternate_Justification { get; set; }
        public bool Is_Requirement { get; set; }
        public int Question_Or_Requirement_Id { get; set; }
        public int Component_Id { get; set; }
        public Nullable<int> Question_Number { get; set; }
        public string Answer_Text { get; set; }
        public string Component_Guid { get; set; }
        public bool Is_Component { get; set; }
        public bool Is_Framework { get; set; }
    }
}

