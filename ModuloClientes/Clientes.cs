
namespace ModuloClientes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Clientes
    {
        public int ID { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Edad { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        [EmailAddress]
        public string correo { get; set; }
    }
}
