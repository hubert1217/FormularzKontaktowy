using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormularzKontaktowy.Models
{
    public class Client
    {

        public int ID { set; get; }
        [Required(ErrorMessage = "Prosze podac swoje imię i nazwisko.")]
        public string Name { set; get; }
        [Required(ErrorMessage ="Prosze podac adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Proszę podac prawidłowy adres e-mail.")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Prosze podac adres zamieszkania.")]
        public string Address { set; get; }
        [Required(ErrorMessage = "Prosze podac swój numer telefonu.")]
        public string Phone { set; get; }
        [Required(ErrorMessage = "Prosze podac czy zgłoszenie jest pilne.")]
        public bool? Urgent { set; get; }
    }
}