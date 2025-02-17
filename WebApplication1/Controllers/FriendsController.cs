namespace WebApplication1.Controllers;

using Microsoft.AspNetCore.Mvc;

using WebApplication1.Abstract;
using WebApplication1.Models;

public class FriendsController(/*IFriendsService service*/)
  : Controller
{

  private readonly List<Friend> friends =
    [
      new Friend { Id = 1, Name = "John Doe", Email = "" },
      new Friend { Id = 2, Name = "Jane Doe", Email = "" }
    ];

  [HttpGet]
  public IActionResult GetFriends() => View(friends);

  [HttpGet("DeleteFriend/{id}")]
  public IActionResult DeleteFriend(int id) => RedirectToAction("GetFriends");
}