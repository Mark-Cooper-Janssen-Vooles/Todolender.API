﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todolender.API.Models.Domain;
using Todolender.API.Models.DTO.ScheduledTodo;
using Todolender.API.Repositories;

namespace Todolender.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        //[HttpPost]
        //[Route("{userId:guid}")]
        //[ActionName("CreateTodoAsync")]
        //[Authorize(Policy = "user")]
        //public async Task<IActionResult> CreateTodoAsync([FromRoute] Guid userId, [FromBody] CreateTodoRequest createTodoRequest)
        //{
        //    var todo = mapper.Map<STodo>(createTodoRequest);
        //    todo = await todoRepository.CreateTodoAsync(userId, todo);
        //    var todoDTO = mapper.Map<TodoDTO>(todo);

        //    return new CreatedAtActionResult(nameof(CreateTodoAsync), "Todo", new { id = todo.Id }, todoDTO);
        //}
    }
}
