using System;

namespace C969Scheduling
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLine { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        private static int count = 0;

        public Address(int addressId, string addressLine, string addressLine2, int cityId, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressId = addressId > count ? addressId : count;
            count = Math.Max(addressId, count);
            Initialize(addressLine, addressLine2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy);
        }

        public Address(string addressLine, string addressLine2, int cityId, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressId = ++count;
            Initialize(addressLine, addressLine2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy);
        }

        private void Initialize(string addressLine, string addressLine2, int cityId, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressLine = addressLine;
            AddressLine2 = addressLine2;
            CityId = cityId;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
    }
}
