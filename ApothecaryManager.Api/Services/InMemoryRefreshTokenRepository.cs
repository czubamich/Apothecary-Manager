using ApothecaryManager.Api.Models;
using ApothecaryManager.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Services
{
    class InMemoryRefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly List<RefreshToken> _refreshTokens = new List<RefreshToken>();

        public Task Create(RefreshToken refreshToken)
        {
            refreshToken.Id = Guid.NewGuid();

            _refreshTokens.Add(refreshToken);

            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            _refreshTokens.RemoveAll(r => r.Id == id);

            return Task.CompletedTask;
        }

        public Task DeleteAll(int userId)
        {
            _refreshTokens.RemoveAll(r => r.UserId == userId);

            return Task.CompletedTask;
        }

        public Task<RefreshToken> GetByToken(string token)
        {
            RefreshToken refreshToken = _refreshTokens.FirstOrDefault(repo => repo.Token == token);

            return Task.FromResult(refreshToken);
        }
    }
}
