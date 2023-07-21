using Nippon.PaintPartner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Application.Interfaces
{
    public interface IAddressService
    {
        public Task<IEnumerable<Address>> GetAllAddressAsync(CancellationToken cancellationToken);
        public Task<string> AddAddressAsync(string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int createdBy, CancellationToken cancellationToken);
        public Task<string> UpdateAddressAsync(int addressId, string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int modifiedBy, CancellationToken cancellationToken);
        public Task<string> DeleteAddressAsync(int addressId, int modifiedBy, CancellationToken cancellationToken);
        public Task<string> ActiveDeactiveAddressAsync(int addressId, bool status, int modifiedBy, CancellationToken cancellationToken);
        public Task<IEnumerable<Address>> PrintAddressAsync(int addressId, CancellationToken cancellationToken);

    }
}
