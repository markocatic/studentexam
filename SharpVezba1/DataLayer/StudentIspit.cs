//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpVezba1.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentIspit
    {
        public int idStudentIspit { get; set; }
        public int idStudent { get; set; }
        public int idIspit { get; set; }
        public Nullable<byte> ocena { get; set; }
        public System.DateTime dvPrijave { get; set; }
    
        public virtual Ispit Ispit { get; set; }
        public virtual Student Student { get; set; }
    }
}
