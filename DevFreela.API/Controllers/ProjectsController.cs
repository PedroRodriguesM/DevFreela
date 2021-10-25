using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        //api/project?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            //Buscar todos ou filtrar
            return Ok();
        }

        //api/project/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Buscar o projeto
            //return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            //Cadastrar o projeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        //api/project/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            //Atualizo o objeto

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retornar NotFound

            //Remover

            return NoContent();
        }
    }
}
