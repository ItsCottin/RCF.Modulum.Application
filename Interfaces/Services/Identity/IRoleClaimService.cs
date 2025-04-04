﻿using System.Collections.Generic;
using System.Threading.Tasks;
using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Identity;
using modulum.Application.Responses.Identity;
using modulum.Shared.Wrapper;

namespace modulum.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}