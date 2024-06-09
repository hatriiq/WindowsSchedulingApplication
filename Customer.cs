using System;

namespace C969Scheduling
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string CustomerName { get; private set; }
        public int AddressId { get; private set; }
        public byte Active { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public string LastUpdateBy { get; private set; }

        private static int count = 0;

        public Customer(int customerId, string customerName, int addressId, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressId = addressId;
            Active = (byte)active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
            count = Math.Max(count, customerId);
        }

        public Customer(string customerName, int addressId, int active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
            : this(++count, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
        {
        }
    }
}
