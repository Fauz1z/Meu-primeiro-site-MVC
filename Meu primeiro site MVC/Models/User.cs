using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Web_App_example.Models
{
    public class User
    {

        public User()
        {

            IsAdmin = false;
            Created = DateTime.Now;



        }




        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public Boolean IsAdmin { get; set; }

        public Byte[]? Photo { get; set; }

        public string? FavoriteColor { get; set; }


        public string Gender { get; set; }
        public string? Profession { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; }
    }



    
}

