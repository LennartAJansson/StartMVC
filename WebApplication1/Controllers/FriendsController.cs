namespace WebApplication1.Controllers;

using Microsoft.AspNetCore.Mvc;

using WebApplication1.Abstract;
using WebApplication1.Models;

public class FriendsController(IFriendsService service)
  : Controller
{
  //Initialize AddFriendView
  public IActionResult AddFriend()
  {
    //Skapar och returnern vyn för inmatning av vän
    return View();
  }

  //AddFriendView OnSubmit
  public IActionResult AddFriendSubmit()
  {
    //Form submit i vyn kommer hit, hur hittar jag min postade form?
    //this.HttpContext.Request...
    return Ok();
  }

  //AddFriendView OnReset
  public IActionResult AddFriendReset()
  {
    return View();
  }

  public IActionResult GetFriends()
  {
    return View();
  }
}
