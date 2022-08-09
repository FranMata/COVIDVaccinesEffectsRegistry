using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class EventSymptomResult
    {
        public EventSymptomResult()
        {
            EventSymptomResultRegistereds = new HashSet<EventSymptomResultRegistered>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EventSymptomResultRegistered> EventSymptomResultRegistereds { get; set; }
    }
}
