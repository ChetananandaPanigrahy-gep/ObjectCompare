using System;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class DispatchHistory
    {
        public string Action { get; set; }
        public string PerformedBy { get; set; }
        public DateTime DatePerformed { get; set; }
        public string AdditionalInfo { get; set; }
    }
}