using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store.Management.Service.Application.Dtos;
using Store.Management.Service.Application.UseCases.Queries;

namespace Store.Management.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger,
            IMediator mediator,
            IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("find-product")]
        [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateOrder([FromQuery] FindProductQueryDto findProductQueryDto)
        {
            return Ok(await _mediator.Send(_mapper.Map<FindProductRequestQuery>(findProductQueryDto)));
        }
    }
}
