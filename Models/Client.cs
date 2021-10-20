using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Equipe2_PneuStore.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Nome Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CPF Obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "E-mail Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone Obrigatório")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Data de Nascimento Obrigatório")]
        [DataType(DataType.Date)]

        public DateTime BirthDate { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string ZipCode { get; set; }   
        
        public string City { get; set; }

        public string State { get; set; }

    }
}
