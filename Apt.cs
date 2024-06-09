using System;

namespace C969Scheduling
{
    public class Apt
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        private static int count = 0;

        public Apt(int customerId, int userId, string type, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AppointmentId = ++count;
            CustomerId = customerId;
            UserId = userId;
            Type = type;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public Apt(int appointmentId, int customerId, int userId, string type, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
            : this(customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
        {
            AppointmentId = appointmentId > count ? appointmentId : count;
        }
    }
}
