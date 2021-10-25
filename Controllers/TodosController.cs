using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TodoListWebAPI.Models;
using TodoListWebAPI.Services;

namespace TodoListWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodosRepository _todosRepository;

        public TodosController(ITodosRepository todosRepository)
        {
            _todosRepository = todosRepository;
        }

        // GET
        [HttpGet]
        public object Get()
        {
            return new {data = _todosRepository.Items, message = "Get Todo Items is Completed"};
        }
        
        // PUT
        [HttpPut("{id}")]
        public object Put(long id, ToDoItem newItem)
        {
            if (_todosRepository.update(id, newItem))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}