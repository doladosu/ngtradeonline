﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FanSelector.Data.Auth
{
    public class AuthRepository : IDisposable
    {
        private readonly FsDataContext _db;
        private readonly ApplicationUserManager _userManager;

        public AuthRepository()
        {
            _db = new FsDataContext();
            _userManager = GetUserManager();
        }

        private ApplicationUserManager GetUserManager()
        {
            try
            {
                return HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            catch (Exception)
            {
                return new ApplicationUserManager(new UserStore<ApplicationUser>(_db));
            }
        }

        public async Task<ApplicationUser> FindUser(string userName, string password)
        {
            try
            {
                return await _userManager.FindAsync(userName, password);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<ApplicationUser> FindByUserName(string userName)
        {
            return await _userManager.FindByNameAsync(userName);
        }

        public async Task<ApplicationUser> FindById(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        public Client FindClient(string clientId)
        {
            return _db.Clients.Find(clientId);
        }

        public async Task<bool> AddRefreshToken(RefreshToken token)
        {
            var existingToken = await _db.RefreshTokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).FirstOrDefaultAsync();
            if (existingToken != null)
            {
                await RemoveRefreshToken(existingToken);
            }

            _db.RefreshTokens.Add(token);

            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = await _db.RefreshTokens.FindAsync(refreshTokenId);

            if (refreshToken == null) return false;
            _db.RefreshTokens.Remove(refreshToken);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            _db.RefreshTokens.Remove(refreshToken);
            return await _db.SaveChangesAsync() > 0;
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            return await _db.RefreshTokens.FindAsync(refreshTokenId);
        }

        public List<RefreshToken> GetAllRefreshTokens()
        {
            return _db.RefreshTokens.ToList();
        }

        public async Task<RefreshToken> GenerateRefreshToken(RefreshToken token)
        {
            return await _db.RefreshTokens.Where(r => r.Subject == token.Subject && r.ClientId == token.ClientId).FirstOrDefaultAsync();
        }

        public void Dispose()
        {

        }
    }
}