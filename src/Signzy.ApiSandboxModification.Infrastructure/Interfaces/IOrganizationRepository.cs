﻿using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IOrganizationRepository
    {
        public Task<IEnumerable<TblAuth>> GetTokenUserIdAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<TblAuth>> SearchUanAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<TblAuth>> UdyamRegistrationAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<StateMasterModel>> GetAllStateListAsync(CancellationToken cancellationToken);
    }
}
