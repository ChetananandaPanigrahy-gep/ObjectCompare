using static Gep.Cumulus.CSM.Notification.Entities.NotificationEnum;

namespace GEP.SMART.Invoice.BusinessEntities
{
    public class ReminderSetting
    {
        public NotificationType NotificationType { get; set; }
        public int AlertType { get; set; }
        public int AlertStart { get; set; }
        public AlertFrequency AlertFrequency { get; set; }
        public string AlertEventCode { get; set; }
        public bool IsReOccurrence { get; set; }
        public int ReOccurrenceStart { get; set; }
        public int ReOccurrenceEnd { get; set; }
        public AlertFrequency ReOccurrenceFrequency { get; set; }
        public int OccurrenceTimes { get; set; }
        public Till Till { get; set; }
    }
}