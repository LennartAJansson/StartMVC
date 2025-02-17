namespace WebApplication1.Models;

public sealed class Friend
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public ICollection<Pet> Pets { get; set; }
  public ICollection<Quote> Quotes { get; set; }
}

public class Quote
{
}

public class Pet
{
}

public sealed class Address
{
  public int Id { get; set; }
  public string Street { get; set; }
  public string City { get; set; }
  public string Country { get; set; }
  public ICollection<Friend> Friends { get; set; }
}

public sealed class CitiesCount
{
  public string Key { get; set; }
  public int Count { get; set; }
}