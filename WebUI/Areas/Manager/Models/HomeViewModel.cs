using Core.Entities.Concrete;

namespace WebUI.Areas.Manager.Models
{
    public class HomeViewModel
    {

        public User currentUser { get; set; } = new User { FirstName = "Empty", LastName = "name" ,Email="emtry@gmail.com"};
    }
}
