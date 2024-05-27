﻿using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDDController : ControllerBase
    {
        private readonly IDDDCadastro _DDDCadastro;

        public DDDController(IDDDCadastro DDDCadastro)
        {
            _DDDCadastro = DDDCadastro;
        }

        [HttpGet("ListaR")]
        public IActionResult GetContato()
        {
            return Ok(_DDDCadastro.ListarDDD());
        }

    }
}
