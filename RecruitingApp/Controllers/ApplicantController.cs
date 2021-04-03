
using AutoMapper;
using RecruitingApp.Data;
using RecruitingApp.IRepository;
using RecruitingApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ApplicantController> _logger;
        private readonly IMapper _mapper;

        public ApplicantController(IUnitOfWork unitOfWork, ILogger<ApplicantController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetApplicants()
        {
            var applicants = await _unitOfWork.Applicants.GetAll();
            var results = _mapper.Map<IList<ApplicantDTO>>(applicants);
            return Ok(results);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{id:int}", Name = "GetApplicant")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetApplicant(int id)
        {
            // Adminstrator => Recruiter? Käyttäjä voi katsoa vain 
            var applicant = await _unitOfWork.Applicants.Get(q => q.Id == id, new List<string> { "Job" });
            var result = _mapper.Map<ApplicantDTO>(applicant);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateApplicant([FromBody] CreateApplicantDTO applicantDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateApplicant)}");
                return BadRequest(ModelState);
            }

            var applicant = _mapper.Map<Applicant>(applicantDTO);
            await _unitOfWork.Applicants.Insert(applicant);
            await _unitOfWork.Save();

            return CreatedAtRoute("CreateApplicant", new { id = applicant.Id }, applicant);
        }

        [Authorize]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateApplicant(int id, [FromBody] UpdateApplicantDTO applicantDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateApplicant)}");
                return BadRequest(ModelState);
            }


            var applicant = await _unitOfWork.Applicants.Get(q => q.Id == id);
            if (applicant == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateApplicant)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(applicantDTO, applicant);
            _unitOfWork.Applicants.Update(applicant);
            await _unitOfWork.Save();

            return NoContent();

        }

        [Authorize]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteApplicant(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteApplicant)}");
                return BadRequest();
            }

            var applicant = await _unitOfWork.Applicants.Get(q => q.Id == id);
            if (applicant == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteApplicant)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Applicants.Delete(id);
            await _unitOfWork.Save();

            return NoContent();

        }
    }
}