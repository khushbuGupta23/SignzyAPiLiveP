using Dapper;
using Nippon.PaintPartner.Domain.Entities;
using Nippon.PaintPartner.Infrastructure.Data.Dapper;
using Nippon.PaintPartner.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Repository
{
    public class AddressRepository : DapperRepository, IAddressRepository
    {
        private readonly DapperCommand _address =
           new DapperCommand("dbo.npnSp_Get_AddressMaster_Data", CommandType.StoredProcedure);
        
        private readonly DapperCommand _addAddress =
           new DapperCommand("dbo.npnSp_Add_AddressMaster_Data", CommandType.StoredProcedure);
        
        private readonly DapperCommand _updateAddress =
           new DapperCommand("dbo.npnSp_Update_AddressMaster_Data", CommandType.StoredProcedure);
        
        private readonly DapperCommand _deleteAddress =
           new DapperCommand("dbo.npnSp_Delete_AddressMaster", CommandType.StoredProcedure);
        
        private readonly DapperCommand _activeDeactiveAddress =
           new DapperCommand("dbo.npnSp_Active_AddressMaster", CommandType.StoredProcedure);

        private readonly DapperCommand _printAddress =
           new DapperCommand("dbo.npn_Sp_GetGridAddressDetails", CommandType.StoredProcedure);

        public AddressRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
            base(dbConnectionFactory, dapperWrapper)
        {
        }

        public async Task<IEnumerable<Address>> GetAllAddressAsync(CancellationToken cancellationToken)
        {
            try
            {
                var result = await DapperWrapper.QueryAsync<Address>(GetConnection(),
                   _address, cancellationToken);

                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public async Task<string> AddAddressAsync(string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int createdBy, CancellationToken cancellationToken)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add(Mapping.Mapping.AddressName, address);
                parameters.Add(Mapping.Mapping.Address1, address1);
                parameters.Add(Mapping.Mapping.Address2, address2);
                parameters.Add(Mapping.Mapping.Landmark, landmark);
                parameters.Add(Mapping.Mapping.Pincode, pincode);
                parameters.Add(Mapping.Mapping.City, city);
                parameters.Add(Mapping.Mapping.State, state);
                parameters.Add(Mapping.Mapping.Country, country);
                parameters.Add(Mapping.Mapping.ContactNo, contact);
                parameters.Add(Mapping.Mapping.CreatedBy, createdBy);

                int result = await DapperWrapper.ExecuteAsync(GetConnection(),
                       _addAddress, parameters, cancellationToken);

                if (result > 0)
                    return "Success";
                else
                    return "Failure";
            }
            catch(Exception ex)
            {
                return "Failure";
            }
            
        }

        public async Task<string> UpdateAddressAsync(int addressId, string address, string address1, string address2, string landmark, string pincode, string city, string state, string country, string contact, int modifiedBy, CancellationToken cancellationToken)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add(Mapping.Mapping.AddressID, addressId);
                parameters.Add(Mapping.Mapping.AddressName, address);
                parameters.Add(Mapping.Mapping.Address1, address1);
                parameters.Add(Mapping.Mapping.Address2, address2);
                parameters.Add(Mapping.Mapping.Landmark, landmark);
                parameters.Add(Mapping.Mapping.Pincode, pincode);
                parameters.Add(Mapping.Mapping.City, city);
                parameters.Add(Mapping.Mapping.State, state);
                parameters.Add(Mapping.Mapping.Country, country);
                parameters.Add(Mapping.Mapping.ContactNo, contact);
                parameters.Add(Mapping.Mapping.ModifiedBy, modifiedBy);

                int result = await DapperWrapper.ExecuteAsync(GetConnection(),
                       _updateAddress, parameters, cancellationToken);

                if (result > 0)
                    return "Success";
                else
                    return "Failure";
            }
            catch(Exception ex)
            {
                return "Failure";
            }
        }

        public async Task<string> DeleteAddressAsync(int addressId, int modifiedBy, CancellationToken cancellationToken)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add(Mapping.Mapping.AddressID, addressId);
                parameters.Add(Mapping.Mapping.ModifiedBy, modifiedBy);

                int result = await DapperWrapper.ExecuteAsync(GetConnection(),
                       _deleteAddress, parameters, cancellationToken);

                if (result > 0)
                    return "Success";
                else
                    return "Failure";
            }
            catch (Exception ex)
            {
                return "Failure";
            }
        }

        public async Task<string> ActiveDeactiveAddressAsync(int addressId, bool status, int modifiedBy, CancellationToken cancellationToken)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add(Mapping.Mapping.AddressID, addressId);
                parameters.Add(Mapping.Mapping.Status, status);
                parameters.Add(Mapping.Mapping.ModifiedBy, modifiedBy);

                int result = await DapperWrapper.ExecuteAsync(GetConnection(),
                       _activeDeactiveAddress, parameters, cancellationToken);

                if (result > 0)
                    return "Success";
                else
                    return "Failure";
            }
            catch(Exception ex)
            {
                return "Failure";
            }
        }

        public async Task<IEnumerable<Address>> PrintAddressAsync(int addressId, CancellationToken cancellationToken)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add(Mapping.Mapping.AddressID, addressId);

                var result = await DapperWrapper.QueryAsync<Address>(GetConnection(),
                       _printAddress, parameters, cancellationToken);

                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
