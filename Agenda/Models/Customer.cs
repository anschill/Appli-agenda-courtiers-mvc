using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        //Taille maximum, ne peut pas être null
        [MaxLength(50), Required]
        public String LastName { get; set; }
        [MaxLength(50), Required]
        public String FirstName { get; set; }
        [MaxLength(150), Required]
        public String Mail { get; set; }
        [MaxLength(10), Required]
        public  String PhoneNumber { get; set; }
        public double Budget { get; set; }
        [MaxLength(50), Required]
        public String Subject { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}