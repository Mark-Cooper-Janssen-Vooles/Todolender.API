﻿namespace Todolender.API.Models.DTO
{
    public class PlanReminderDTO
    {
        public Guid UserId { get; set; }
        public bool PlanReminderOn { get; set; }
        public string? Frequency { get; set; }
        public DateTime? NextScheduledAt { get; set; }
        public string? Description { get; set; }
    }
}
