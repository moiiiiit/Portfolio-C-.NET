using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;

namespace portfolio_backend.Controllers{
    [Route("api/GetExperiences")]
    [ApiController]
    public class GetExperiencesController : ControllerBase{
        private readonly PortfolioRepo _repository;

        public GetExperiencesController(PortfolioRepo repository){
            _repository = repository;
        } 
        [HttpGet("{userid}")]
        public ActionResult <SortedList<int, int>> GetUser(int userid){
            return Ok(_repository.GetExperiences(userid));
        }

    }
    
}