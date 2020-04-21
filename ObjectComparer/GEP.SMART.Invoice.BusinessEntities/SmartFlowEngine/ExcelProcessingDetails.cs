using System;
using System.Runtime.InteropServices;

namespace GEP.SMART.Invoice.BusinessEntities.SmartFlowEngine
{
    public class ExcelProcessingDetails:IDisposable
    {
        public long Id { get; set; }

        public long FileId { get; set; }

        public Guid TransactionId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string HeaderLevelErrorDirectory { get; set; }

        public int Status { get; set; }

        public string FilePath { get; set; }

        public long NumberOfInvoices { get; set; }

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