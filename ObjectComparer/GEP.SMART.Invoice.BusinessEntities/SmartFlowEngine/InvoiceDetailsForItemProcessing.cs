using GEP.Cumulus.Documents.Entities;
using System;
using System.Runtime.InteropServices;

namespace GEP.SMART.Invoice.BusinessEntities.SmartFlowEngine
{
    public class InvoiceDetailsForItemProcessing: IDisposable
    {
        public long InvoiceId { get; set; }

        public string DocumentNumber { get; set; }

        public DocumentStatus InvoiceStatus { get; set; }

        public InvoiceOperation InvOperation { get; set; }

        public string InvoiceAction { get; set; }

        public string ShippingMethod { get; set; }

        public InvoiceOrigin InvOrigin { get; set; }

        public DocumentStatus DocumentStatusInfo { get; set; }

        public int BusinessUnitId { get; set; }

        public string BusinessUnitName { get; set; }

        public decimal? InvoiceTotalAmount { get; set; }

        public string PartnerInvoiceNumber { get; set; }

        public long NumberOfItems { get; set; }

        public bool SplitSaveSuccess { get; set; }
        
        public int StructureId { get; set; }

        private bool isDisposed;
        private IntPtr nativeResource = Marshal.AllocHGlobal(100);


        // Dispose() calls Dispose(true)
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // The bulk of the clean-up code is implemented in Dispose(bool)
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            // free native resources if there are any.
            if (nativeResource != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(nativeResource);
                nativeResource = IntPtr.Zero;
            }

            isDisposed = true;
        }
    }
}