using System.Collections.Generic;
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

        public CommndsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
 
        // Return all commands 
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }       

        // GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandByID(id);
            return Ok(commandItem);
        }
    }
}