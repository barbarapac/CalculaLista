using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaListaAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CalculaListaAPI.Controllers
{
    [Produces("application/json", "text/plain")]
    [ApiController]
    [Route("api/[controller]")]
    public class CalculaListaController : ControllerBase
    {
        private readonly IConfiguration _config;

        public CalculaListaController(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Calcula números da lista, conforme métodos solicitados (soma total, soma pares, média, maior e menor).
        /// </summary>
        /// <param name="numeros"></param>
        /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> RegistrarCepFavorito([FromBody] List<int> numeros)
        {
            try
            {
                RetListaCalculadaDTO ret = new RetListaCalculadaDTO();

                ret = BO.CalculaListaBO.RetornaCalculosLista(numeros);

                return Ok(ret);
            }
            catch (Exception)
            {
                return UnprocessableEntity("Ops! Ocorreu um problema ao calcular a lista. Tente novamente!");
            }
        }

    }
}
