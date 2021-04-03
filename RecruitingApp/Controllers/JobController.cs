using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using RecruitingApp.IRepository;
using RecruitingApp.Models;

namespace RecruitingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<JobController> _logger;
        private readonly IMapper _mapper;

        public JobController(IUnitOfWork unitOfWork, ILogger<JobController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await _unitOfWork.Jobs.GetAll();
            var result = _mapper.Map<IList<JobDTO>>(jobs);
            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetJob(int id)
        {

            var job = await _unitOfWork.Jobs.Get(row => row.Id == id, new List<string>{"Applicants"});
            var result = _mapper.Map<JobDTO>(job);
            return Ok(result);
        }
    }
}
