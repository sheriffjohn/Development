using SimpleWebStore.Domain.Entities;

namespace SimpleWebStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}