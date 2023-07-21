using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nippon.PaintPartner.Application.Interfaces;
using Nippon.PaintPartner.Domain.Entities;

namespace Nippon.PaintPartner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        [Route("GetAllAddressAsync")]
        public async Task<IEnumerable<Address>> GetAllAddressAsync(CancellationToken cancellationToken)
        {
            return await _addressService.GetAllAddressAsync(cancellationToken);
        }

        [HttpPost]
        [Route("AddAddressAsync")]
        public async Task<string> AddAddressAsync(string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int createdBy, CancellationToken cancellationToken)
        {
            return await _addressService.AddAddressAsync(address, address1, address2, landmark, pincode, city, state, country, contact, createdBy, cancellationToken);
        }

        [HttpPut]
        [Route("UpdateAddressAsync")]
        public async Task<string> UpdateAddressAsync(int addressId, string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int modifiedBy, CancellationToken cancellationToken)
        {
            return await _addressService.UpdateAddressAsync(addressId, address, address1, address2, landmark, pincode, city, state, country, contact, modifiedBy, cancellationToken);
        }

        [HttpDelete]
        [Route("DeleteAddressAsync")]
        public async Task<string> DeleteAddressAsync(int addressId, int modifiedBy, CancellationToken cancellationToken)
        {
            return await _addressService.DeleteAddressAsync(addressId, modifiedBy, cancellationToken);
        }

        [HttpPut]
        [Route("ActiveDeactiveAddressAsync")]
        public async Task<string> ActiveDeactiveAddressAsync(int addressId, bool status, int modifiedBy, CancellationToken cancellationToken)
        {
            return await _addressService.ActiveDeactiveAddressAsync(addressId, status, modifiedBy, cancellationToken);
        }

        [HttpGet]
        [Route("PrintAddressAsync")]
        public async Task<IEnumerable<Address>> PrintAddressAsync(int addressId, CancellationToken cancellationToken)
        {
            return await _addressService.PrintAddressAsync(addressId, cancellationToken);
        }
    }
}
