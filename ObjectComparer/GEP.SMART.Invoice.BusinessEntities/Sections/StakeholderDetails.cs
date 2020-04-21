namespace GEP.SMART.Invoice.BusinessEntities
{
    public class StakeholderDetails
    {
        public StakeholderDetails()
        {
            OrderContact = new IdNameAndEmail();
        }

        public long DocumentCode { get; set; }
        public IdNameAndEmail OrderContact { get; set; }
        public string BuyerEmailPhone { get; set; }
    }
}