﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class Venda
    {
        [BindNever]
        public int VendaId { get; set; }

        public List<VendaDetalhe> DetalhesVenda { get; set; }

        [Required(ErrorMessage = "Entre com seu nome")]
        [Display(Name = "Primeiro nome")]
        [StringLength(50)]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Entre com seu sobrenome")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Endereço")]
        [StringLength(100)]
        [Display(Name = "Rua")]
        public string Endereco1 { get; set; }

        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "Código Postal")]
        [Display(Name = "CEP")]
        [StringLength(15, MinimumLength = 4)]
        public string CEP { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }


        [StringLength(50)]
        public string Pais { get; set; }


        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Seu email não está no formato correto!")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal TotalVenda { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime DataVenda { get; set; }
    }

}