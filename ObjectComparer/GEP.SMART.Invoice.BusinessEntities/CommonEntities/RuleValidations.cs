using REDataModel;
using System;
using System.Runtime.Serialization;

namespace GEP.SMART.Invoice.BusinessEntities
{
    [DataContract]
    [Serializable]
    public class RuleValidations
    {
        [DataMember]
        public ActionType Action { get; set; }

        [DataMember]
        public string ValidationMessage { get; set; }
    }
}