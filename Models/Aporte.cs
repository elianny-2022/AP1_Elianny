using System.ComponentModel.DataAnnotations;


public class Aporte
{
    [Key]
    public int AporteId { get; set; }
    [Required(ErrorMessage ="Se necesita la el aporte")]
    public String? Persona { get; set; }
    [Range(1, 1_000_000)]
    public double Monto { get; set; }
    
}