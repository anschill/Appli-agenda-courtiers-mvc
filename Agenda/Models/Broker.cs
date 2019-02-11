using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Broker
    {
        
        public int BrokerID { get; set; }
        [MaxLength(50), Required]
        public String LastName { get; set; }
        [MaxLength(50), Required]
        public String FirstName { get; set; }
        [MaxLength(50), Required]
        public String Mail { get; set; }
        [MaxLength(10), Required]
        public String PhoneNumber { get; set; }
        //le virtual se lance en dernier seulement si l'appointment existe, Icollection = création d'une
        //collection d'éléments, car la relation est 1,N
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
