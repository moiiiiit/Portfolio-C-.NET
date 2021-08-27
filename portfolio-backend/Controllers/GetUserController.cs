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
        [HttpGet("{name}")]
        public ActionResult <SortedList<int, int>> GetUser(string name){
            return Ok(_repository.GetUser(name));
        }

    }
    
}