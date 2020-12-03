using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommndsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommndsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
 
        // Return all commands 
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }       

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandByID(id);
            if(commandItem != null)
            {
                return Ok(commandItem);
            }
            return NotFound();
        }
    }
}