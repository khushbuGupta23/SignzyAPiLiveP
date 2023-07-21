using Nippon.PaintPartner.Application.Interfaces;
using Nippon.PaintPartner.Domain.Entities;
using Nippon.PaintPartner.Infrastructure.Interfaces;
using Nippon.PaintPartner.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IActivityLogRepository _activityLogRepository;

        public AddressService(IAddressRepository addressRepository, IActivityLogRepository activityLogRepository)
        {
            _addressRepository = addressRepository;
            _activityLogRepository = activityLogRepository;
        }
        public async Task<IEnumerable<Address>> GetAllAddressAsync(CancellationToken cancellationToken)
        {
            return await _addressRepository.GetAllAddressAsync(cancellationToken);
        }

        public async Task<string> AddAddressAsync(string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int createdBy, CancellationToken cancellationToken)
        {
            var res = await _addressRepository.AddAddressAsync(address, address1, address2, landmark, pincode, city, state, country, contact, createdBy, cancellationToken);
            if (res == "Success")
            {
                var output = _activityLogRepository.AddUserActivityLogAsync("Admin", "Master Management", "Add Address", "Address Data Added", createdBy, cancellationToken);
                return res;
            }
            else
                return "Failure";

        }

        public async Task<string> UpdateAddressAsync(int addressId, string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int modifiedBy, CancellationToken cancellationToken)
        {
            var res = await _addressRepository.UpdateAddressAsync(addressId, address, address1, address2, landmark, pincode, city, state, country, contact, modifiedBy, cancellationToken);
            if (res == "Success")
            {
                var output = _activityLogRepository.AddUserActivityLogAsync("Admin", "Master Management", "Edit Address", "Address data Edited", modifiedBy, cancellationToken);
                return res;
            }
            else
                return "Failure";
        }

        public async Task<string> DeleteAddressAsync(int addressId, int modifiedBy, CancellationToken cancellationToken)
        {
            var res = await _addressRepository.DeleteAddressAsync(addressId, modifiedBy, cancellationToken);
            if (res == "Success")
            {
                var output = _activityLogRepository.AddUserActivityLogAsync("Admin", "Master Management", "Delete Address", "Address Deleted", modifiedBy, cancellationToken);
                return res;
            }
            else
                return "Failure";
        }

        public async Task<string> ActiveDeactiveAddressAsync(int addressId, bool status, int modifiedBy, CancellationToken cancellationToken)
        {
            return await _addressRepository.ActiveDeactiveAddressAsync(addressId, status, modifiedBy, cancellationToken);
        }

        public async Task<IEnumerable<Address>> PrintAddressAsync(int addressId, CancellationToken cancellationToken)
        {
            return await _addressRepository.PrintAddressAsync(addressId, cancellationToken);
        }
    }
}
