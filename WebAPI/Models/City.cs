using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class City
    {
        public int Id {get;set;}
       public string Name {get;set;}
        [Required]

       public string Country {get;set;}

     public DateTime LastUpdated {get;set;}
    public int LastUpdatedBy {get;set;}



    }
}