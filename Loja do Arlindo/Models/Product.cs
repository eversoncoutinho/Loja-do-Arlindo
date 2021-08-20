using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja_do_Arlindo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InicialAmmount { get; set; }
        [Foolproof.GreaterThan("InicialAmmount", 
                                ErrorMessage = "A quantidade final não pode ser menor que a inicial")]
        public int FinalAmmount { get; set; }

        //Data automática
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)] //ajuste do formato
        public DateTime DateCreate { 
                                     get { return dateModified; } 
                                     set { dateModified=value; } 
                                    }
        private DateTime dateModified = DateTime.Now.ToUniversalTime();




    }
}