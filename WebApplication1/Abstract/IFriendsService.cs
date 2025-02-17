namespace WebApplication1.Abstract;

using System.Collections.Generic;
using System.Threading.Tasks;

using WebApplication1.Models;

public interface IFriendsService
{
  Task<IEnumerable<Address>> GetAddresses();
  Task<Address> AddAddress(Address address);
}
