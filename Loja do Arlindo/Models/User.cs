using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja_do_Arlindo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime birthday { get; set; }

    }
}