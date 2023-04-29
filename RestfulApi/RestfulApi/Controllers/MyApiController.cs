using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;
using System.Text.Json;

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
        public IActionResult index()
        {
            string directoryPath = "D:\\RestfulApi\\Item"; // 目錄路徑
            string[] files = Directory.GetFiles(directoryPath); // 取得目錄下的所有檔案名稱
            Model.Data Datas = new Model.Data();
            Datas.Link = files;
            string json = JsonSerializer.Serialize(new { Datas});
            return Ok(json);
        }
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
