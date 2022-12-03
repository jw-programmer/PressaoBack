using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Src.Context;
using Src.Domain;
using Src.Domain.DTO;

namespace Src.Controllers
{


    [Route("api/[Controller]")]
    [ApiController]
    public class PressaoArterialController : ControllerBase
    {
        private readonly PressaoContext _context;
        private readonly IMapper _mapper;

        public PressaoArterialController(PressaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PressaoArterial>> Get()
        {
            var pressoes = _context.PressoesArteriais?.ToList();

            return Ok(pressoes);
        }

        [HttpGet("{id}", Name="ObterPressaoArterial")]
        public ActionResult<PressaoArterial> GetById(long id)
        {
            var pressao = _context.PressoesArteriais?.FirstOrDefault((p) => p.PressaoArterialId == id);

            if(pressao == null)
                return NotFound();

            return pressao;
        }

        [HttpPost]
        public ActionResult<PressaoArterial> Post([FromBody] PressaoArterialDTO pressaoDTO)
        {
            var pressaoArterial = _mapper.Map<PressaoArterial>(pressaoDTO);
            _context.PressoesArteriais?.Add(pressaoArterial);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPressaoArterial", new { id = pressaoArterial.PressaoArterialId}, pressaoArterial);
        }
    }
}