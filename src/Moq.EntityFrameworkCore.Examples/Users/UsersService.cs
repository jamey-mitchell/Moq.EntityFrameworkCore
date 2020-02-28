﻿namespace Moq.EntityFrameworkCore.Examples.Users
{
    using Microsoft.EntityFrameworkCore;
    using Moq.EntityFrameworkCore.Examples.Users.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public class UsersService
    {
        private readonly UsersContext usersContext;

        public UsersService(UsersContext usersContext)
        {
            this.usersContext = usersContext;
        }

        public IList<User> GetLockedUsers()
        {
            return this.usersContext.MockUsers.Where(x => x.AccountLocked).ToList();
        }

        public async Task<IList<User>> GetLockedUsersAsync()
        {
            return await this.usersContext.MockUsers.Where(x => x.AccountLocked).ToListAsync();
        }

        public IList<Role> GetDisabledRoles()
        {
            return this.usersContext.MockRoles.Where(x => !x.IsEnabled).ToList();
        }

        public async Task<IList<Role>> GetDisabledRolesAsync()
        {
            return await this.usersContext.MockRoles.Where(x => !x.IsEnabled).ToListAsync();
        }

        public async Task<User> FindOneUserAsync(Expression<Func<User, bool>> predicate)
        {
            return await this.usersContext.Set<User>().FirstOrDefaultAsync(predicate);
        }
    }
}