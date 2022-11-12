using System.Collections.Generic;
using System;
using GenderSensitiveCommunicationApi.Model;

namespace GenderSensitiveCommunicationApi.Data
{
    public class EntryData
    {
        public List<EntryModel> GetAllEntry()
        {
            return new List<EntryModel>
            {
                new EntryModel
                {
                Id = 1,
                Name = "Phoebe",
                Surname = "Buffey",
                Date = new DateTime(2000, 12, 12),
                Text = "Smelly Cat,It is not your fault"
                },

                new EntryModel
                {
                Id = 2,
                Name = "Monica",
                Surname = "Geller",
                Date = new DateTime(2005, 7, 5),
                Text = "xxx"
                },

                new EntryModel
                {
                Id = 3,
                Name = "Chandler",
                Surname = "Bing",
                Date = new DateTime(1999, 10, 12),
                Text = "xxx"
                },

            };
        }
    }
}
