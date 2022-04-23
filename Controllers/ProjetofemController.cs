using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_API_Banco_Carrefour.Data;
using Projeto_API_Banco_Carrefour.Models;

namespace Projeto_API_Banco_Carrefour.Controllers
{
    [ApiController]
    [Route("v1/projetosfem")]
    public class ProjetofemController : ControllerBase
    {        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<EmpodeiramentoFEM>>> Get([FromServices] DataContext context)
        {
          var empodeiramentoFEMs = await context.EmpodeiramentoFEMs.ToListAsync();
          return empodeiramentoFEMs;
        }
        [HttpPost]
        [Route("")]
         public async Task<ActionResult<EmpodeiramentoFEM>>Post(
             [FromServices] DataContext context, 
             [FromBody]EmpodeiramentoFEM model)
        {
            if(ModelState.IsValid)
            {
                     context.EmpodeiramentoFEMs.Add(model);
                     await context.SaveChangesAsync();
                     return model;
            }
                 else 
            {
                     return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [Route("/v1/projetosfem/list")]
        public async Task<ActionResult<List<EmpodeiramentoFEM>>> Post(
            [FromServices] DataContext context,
            [FromBody] List<EmpodeiramentoFEM> models)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in models)
                {
                    context.EmpodeiramentoFEMs.Add(item);
                }
                await context.SaveChangesAsync();
                return models;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}