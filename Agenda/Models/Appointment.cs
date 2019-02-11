using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateHour { get; set; }
        //clefs étrangères
        public int BrokerID { get; set; }
        public int CustomerID { get; set; }
        //virtual car il s'affiche seulement si Broker existe, on crée de nouveaux éléments
        //de type "Broker"
        public virtual Broker Broker { get; set; }
        public virtual Customer Customer { get; set; }
    }
}