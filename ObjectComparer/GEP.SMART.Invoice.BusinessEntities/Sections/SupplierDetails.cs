using System.Collections.Generic;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class SupplierDetails
    {
        public SupplierDetails()
        {
            OrderingLocation = new IdNameAndAddress() { name = "", nameandnumber = "", address = "" };
            RemittoLocation = new IdNameAndAddress() { name = "", nameandnumber = "", address = "" };
            PartnerContact = new IdNameAndEmail() { name = "", address = "", email = "", fax = "", phone = "" };
            Partner = new IdAndName() { id = 0, name = "" };
        }

        public IdNameAndAddress OrderingLocation { get; set; }
        public string OrderLocationNameAndAddress { get; set; }
        public IdNameAndAddress RemittoLocation { get; set; }
        public string RemitToLocSupplierNameAndAddress { get; set; }
        public IdNameAndEmail PartnerContact { get; set; }
        public string SupplierIdentificationValue { get; set; }
        public List<string> SupplierVatValues { get; set; }
        public IdAndName Partner { get; set; }
    }
}