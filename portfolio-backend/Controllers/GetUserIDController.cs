using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using portfolio_backend.data;
using System;
namespace portfolio_backend.Controllers
{
    [Route("api/GetUser")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        private readonly PortfolioRepo _repository;

        public GetUserController(PortfolioRepo repository)
        {
            _repository = repository;
        }
        [HttpGet("nameorid")]
        public ActionResult<SortedList<int, int>> GetUser([FromQuery] string userid, [FromQuery] string name)
        {
            if (userid!=null && !userid.Equals(""))
            {
                return Ok(_repository.GetUser(Int32.Parse(userid)));
            }
            else
            {
                return Ok(_repository.GetUser(name));
            }

        }

        [HttpGet("{userid}")]
        public ActionResult<SortedList<int, int>> GetUser(int userid)
        {
            return Ok(_repository.GetUser(userid));
        }

    }

}