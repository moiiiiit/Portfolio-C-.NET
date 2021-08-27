using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;

namespace portfolio_backend.Controllers{
    [Route("api/GetProjects")]
    [ApiController]
    public class GetProjectsController : ControllerBase{
        private readonly PortfolioRepo _repository;

        public GetProjectsController(PortfolioRepo repository){
            _repository = repository;
        } 
        [HttpGet("{userid}")]
        public ActionResult <SortedList<int, int>> GetUser(int userid){
            return Ok(_repository.GetProjects(userid));
        }

    }
    
}