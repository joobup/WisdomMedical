//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMHC.SLTC.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_MonitorItem
    {
        public DC_MonitorItem()
        {
            this.DC_MonitorResult = new HashSet<DC_MonitorResult>();
            this.DC_MonitorTemplate = new HashSet<DC_MonitorTemplate>();
        }
    
        public int MonitoritemID { get; set; }
        public string MINo { get; set; }
        public string MIName { get; set; }
        public string Remark { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<DC_MonitorResult> DC_MonitorResult { get; set; }
        public virtual ICollection<DC_MonitorTemplate> DC_MonitorTemplate { get; set; }
    }
}