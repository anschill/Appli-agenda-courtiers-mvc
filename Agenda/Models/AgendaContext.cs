using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    //AgendaContext HERITE de la classe DbContext qui permet d'avoir une instance de la base
    //de données, elle permet d'avoir une connexion, elle permet de manipuler la base de données

    public class AgendaContext : DbContext
    {
        //création d'un constructeur, base signifie le parent
        public AgendaContext()  : base("AgendaContext"){}
        //DbSet est la porte d'entrée pour l'entité, Appointment est le type de la collection, 
        //Appointments sera le nom de la liste qui va répértorier chaque Appointment.
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }   
}