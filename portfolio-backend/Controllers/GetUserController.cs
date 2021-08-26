using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;

namespace portfolio_backend.Controllers{
    [Route("api/GetUser")]
    [ApiController]
    public class GetUserController : ControllerBase{
        private readonly PortfolioRepo _repository;

        public GetUserController(PortfolioRepo repository){
            _repository = repository;
        } 
        [HttpGet("{userid}")]
        public ActionResult <SortedList<int, int>> GetUser(int userid){
            return Ok(_repository.GetUser(userid));
        }

    }
    
}