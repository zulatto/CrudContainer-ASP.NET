using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContainerCRUD.Models
{
    [Table("Container")]
    public class Container
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Numero")]
        [Column("Numero")]
        public string Numero { get; set; }
    }
}
