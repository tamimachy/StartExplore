﻿using Microsoft.EntityFrameworkCore;
using StartExploreAPI.Data;
using StartExploreAPI.Models.Domain;

namespace StartExplore.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly StartExploreDbContext dbContext;
        public SQLWalkRepository(StartExploreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await dbContext.Walks.Include("Difficulty").Include("Region").ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            return await dbContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
