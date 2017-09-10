using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RegattaSailorAPI.Models
{
    [DataContract(IsReference = true)]
    public class DivisionModel
    {
        [Key]
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<YachtModel> Yachts { get; set; }
        [DataMember]
        public int Index { get; set; }
        [DataMember]
        public DateTime? StartTime { get; set; }

        [IgnoreDataMember]
        public virtual RaceModel Race {get; set;}
        [DataMember]
        public virtual List<RaceLegModel> Legs { get; set; }
    }
}