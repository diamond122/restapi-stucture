﻿using System.Threading.Tasks;
using BeautifulRestApi.Dal;
using BeautifulRestApi.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BeautifulRestApi.Queries
{
    public class GetUserQuery
    {
        private readonly BeautifulContext _context;

        public GetUserQuery(BeautifulContext context)
        {
            _context = context;
        }

        public async Task<User> Execute(string id)
        {
            var p = await _context.Users.SingleOrDefaultAsync(x => x.Id == id);

            return p == null
                ? null
                : p.Adapt<User>();
        }
    }
}