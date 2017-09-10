using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegattaSailorAPI.Models
{
    public class RaceModel
    {
        [Key]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        public virtual List<DivisionModel> Divisions { get; set; }
        [IgnoreDataMember]
        public virtual List<RaceLegModel> Legs { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
    }
}