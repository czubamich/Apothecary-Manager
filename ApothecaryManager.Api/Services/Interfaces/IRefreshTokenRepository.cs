using ApothecaryManager.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Services.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task Create(RefreshToken refreshToken);

        Task<RefreshToken> GetByToken(string token);

        Task Delete(Guid Id);
        Task DeleteAll(int userId);
    }
}
