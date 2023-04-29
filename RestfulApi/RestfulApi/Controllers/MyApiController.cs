using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;

namespace RestfulApi.Controllers
{
    [ApiController]
    //url must have api/
    //[Route("{prefix:regex(api)}/[controller]")]

    //url add myapi/
    //[Route("myapi/[controller]")]
    [Route("[controller]")]
    public class MyApiController : ControllerBase
    {

        //HttpGet() url will define this first   
        [HttpGet]      
        //url = MyApi/Show       
        [HttpGet("Show")]
        public IActionResult Show()
        {
  
            var result = new { Message = "url=~/MyApi/Show" };
            return Ok(result);
        }
        // this {id?} is dispensable
        [HttpGet("Display/{id?}")]
        public IActionResult Display(string displayer,int? id) 
        {

            var result = new { Message = "Hello, " + displayer +"     "+id};
            return Ok(result);

        }

        
    }
}
