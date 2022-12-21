﻿namespace Todolender.API.Models.DTO.Todo
{
    public class TodoDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
    }
}
