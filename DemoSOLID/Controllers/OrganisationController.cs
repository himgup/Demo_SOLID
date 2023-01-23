using DemoSOLID.Models;
using DemoSOLID.Services;
using DemoSOLID.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;


namespace DemoSOLID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly IOrganisationService _organisationService;
        public OrganisationController(IOrganisationService organisationService)
        {
            _organisationService = organisationService;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrganisationList))]
        public IActionResult Get()
        {
            return Ok(_organisationService.GetAllOrganisations());
        }
        [HttpGet("{id}")]
        public IActionResult GetOrganisationById(int id)
        {
            return Ok(_organisationService.GetOrganisationById(id));
        }

        //Get 
        [HttpGet]
        [Route("TechCompanies")]
        public IActionResult GetTechCompanies()
        {
            return Ok(_organisationService.GetTechCompanies());
        }

        [HttpGet]
        [Route("details")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OgranisationDetailViewModel))]
        public IActionResult GetOrganisationDetails(int id)
        {
            return Ok(_organisationService.GetOrganisationDetails(id));
        }
        [HttpGet]
        [Route("Revenue")]
        public IActionResult GetCompaniesByRevnue()
        {
            return Ok(_organisationService.GetCompaniesByRevnue());
        }


        [EnableQuery]
        [HttpGet]
        [Route("Odata")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrganisationList))]
        public IActionResult GetAll()
        {
            return Ok(_organisationService.GetAllOrganisationsbyOData());
        }

    }
}
