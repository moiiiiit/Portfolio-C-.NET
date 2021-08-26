using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;

namespace portfolio_backend.Controllers{
    [Route("api/mock")]
    [ApiController]
    public class MockController : ControllerBase{
        private readonly PortfolioRepo _repository;

        public MockController(PortfolioRepo repository){
            _repository = repository;
        } 
        [HttpGet()]
        public ActionResult <SortedList<int, int>> mock(){
            return Ok(_repository.mock(1));
        }

    }
    
}