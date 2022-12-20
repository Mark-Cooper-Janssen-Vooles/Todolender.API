﻿using Microsoft.EntityFrameworkCore;
using Todolender.API.Data;
using Todolender.API.Models.Domain;
using Todolender.API.Repositories.Interfaces;

namespace Todolender.API.Repositories
{
    public class PlanReminderRepository : IPlanReminderRepository
    {
        private readonly TodolenderDbContext dbContext;

        public PlanReminderRepository(TodolenderDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<PlanReminder> GetPlanReminderAsync(Guid userId)
        {
            var planReminder = await dbContext.PlanReminder.FirstOrDefaultAsync(x => x.UserId == userId);
            if (planReminder == null)
            {
                planReminder = new PlanReminder()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    PlanReminderOn = false
                };

                await dbContext.AddAsync(planReminder);
                await dbContext.SaveChangesAsync();
            }

            return planReminder;
        }

        public async Task<PlanReminder> UpdatePlanReminderAsync(Guid userId, PlanReminder updatedPlanReminder)
        {
            var existingPlanReminder = await dbContext.PlanReminder.FirstOrDefaultAsync(x => x.UserId == userId);
            if (existingPlanReminder == null) return null;

            existingPlanReminder.PlanReminderOn = updatedPlanReminder.PlanReminderOn;
            existingPlanReminder.Frequency = updatedPlanReminder.Frequency;
            existingPlanReminder.NextScheduledAt = updatedPlanReminder.NextScheduledAt;
            existingPlanReminder.Description = updatedPlanReminder.Description;

            await dbContext.SaveChangesAsync();

            return existingPlanReminder;
        }
    }
}
