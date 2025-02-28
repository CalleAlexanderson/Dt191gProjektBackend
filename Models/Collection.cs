using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Backend.Models;

public class Collection {
    public int Id {get; set;}
    public Post[]? Posts {get; set;}

    public IdentityUser? User {get; set;}

    [Required(ErrorMessage = "Ange UserId på den användare som skapar denna samling")]
    public int UserId {get; set;}
}
