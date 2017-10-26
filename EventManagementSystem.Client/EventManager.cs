using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.DB;
using EventManagementSystem.Model;


namespace EventManagementSystem.Client
{
    public class EventManager
    {

        //Insert method for adding new events in the database
        public void Insert()
        {
            using (EventContext db = new EventContext())
            {
                try
                {
                    Console.WriteLine("Plese enter : Name, Location , Start Date & Time, End Date & Time of the event. ");
                    db.Events.Add(new Model.Event
                    {
                        Name = Console.ReadLine(),
                        Location = Console.ReadLine(),
                        StartDateTime = DateTime.Parse(Console.ReadLine()),
                        EndDateTime = DateTime.Parse(Console.ReadLine())
                    });
                    db.SaveChanges();
                    Console.WriteLine("Event Added !");
                    Console.WriteLine("---------------------------------------");
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter Valid data");
                }
            }
        }

        //Select Method which returns all events in the database
        public void Select()
        {
            using (EventContext db = new EventContext())
            {
                foreach (var Events in db.Events.ToList())
                {
                    Console.WriteLine("Event Info N= {0} || Event Name - {1} || Event Location - {2}- || Start Date & Time of the event - {3}- || End Date & Time Of the event-{4} ||", Events.Id, Events.Name, Events.Location, Events.StartDateTime, Events.EndDateTime);
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                }
            }

        }
        // Delete method which deletes an event by Id from the database
        public void Delete(int id)
        {
            using (EventContext db = new EventContext())
            {
                try
                {
                    Event even = db.Events.Find(id);
                    db.Events.Remove(even);
                    db.SaveChanges();
                    Console.WriteLine("Event is Deleted!");
                    Console.WriteLine("---------------------------------------");
                }

                catch (Exception)
                {
                    Console.WriteLine("The Id of the event you wish to Delete does not exist or you entered invalid data");
                }
            }
        }
        //Update method which updates an event from the database by Id
        public void Update(int id)
        {

            using (EventContext db = new EventContext())
            {
                try
                {

                    var updatedEvent = db.Events.Find(id);
                    Console.WriteLine("Enter the new name of the event:");
                    updatedEvent.Name = Console.ReadLine();
                    Console.WriteLine("Enter the new location of the event:");
                    updatedEvent.Location = Console.ReadLine();
                    Console.WriteLine("Enter the new start Date");
                    updatedEvent.StartDateTime = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new end date");
                    updatedEvent.EndDateTime = DateTime.Parse(Console.ReadLine());
                    db.SaveChanges();
                    Console.WriteLine("Event Updated!");
                    Console.WriteLine("---------------------------------------");
                }
                catch (Exception)
                {
                    Console.WriteLine("The Id of the event you wish to Update does not exist or you entered invalid data");

                }
            }

        }

    }

}



