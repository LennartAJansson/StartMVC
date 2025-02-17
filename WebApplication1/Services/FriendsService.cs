namespace WebApplication1.Services;

using System.Collections.Generic;
using System.Threading.Tasks;

using WebApplication1.Abstract;
using WebApplication1.Models;

public sealed class FriendsService//(DatabasContext context)
  : IFriendsService
{
  public Task<Address> AddAddress(Address address)
  {
    //Fulkod eftersom jag inte har någon koppling till databas eller api
    address.Id = 1;
    return Task.FromResult(address);  
  }

  public Task<IEnumerable<Address>> GetAddresses()
  {
    return Task.FromResult<IEnumerable<Address>>(
      [
        new Address
        {
          Id = 1,
          Street = "Kungsgatan 1",
          City = "Stockholm",
          Country = "Sweden",
          Friends = [] 
        },
        new Address
        {
          Id = 1,
          Street = "Blekingegatan 1",
          City = "Stockholm",
          Country = "Sweden",
          Friends = []
        },
        new Address
        {
          Id = 1,
          Street = "Sveavägen 1",
          City = "Stockholm",
          Country = "Sweden",
          Friends = []
        },
        new Address
        {
          Id = 1,
          Street = "Götgatan 1",
          City = "Stockholm",
          Country = "Sweden",
          Friends = []
        }
      ]);
  }
}
