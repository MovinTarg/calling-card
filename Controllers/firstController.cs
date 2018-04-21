using Microsoft.AspNetCore.Mvc;
 
namespace calling_card
{
    public class YourController : Controller
    {
        [HttpGet]
        [Route("{first_name}/{last_name}/{age}/{favorite_color}")]
        public JsonResult Calling_Card(string first_name, string last_name, int age, string favorite_color)
        {
            var calling_card = new {FirstName = first_name, LastName = last_name, Age = age, FavoriteColor = favorite_color};
            return Json(calling_card);
        }
    }
}