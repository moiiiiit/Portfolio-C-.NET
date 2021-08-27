using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;

namespace portfolio_backend.Controllers{
    [Route("api/GetIdentifiers")]
    [ApiController]
    public class GetIdentifiersController : ControllerBase{
        private readonly PortfolioRepo _repository;

        public GetIdentifiersController(PortfolioRepo repository){
            _repository = repository;
        } 
        [HttpGet("{userid}")]
        public ActionResult <SortedList<int, int>> GetUser(int userid){
            return Ok(_repository.GetIdentifiers(userid));
        }

    }
    
}