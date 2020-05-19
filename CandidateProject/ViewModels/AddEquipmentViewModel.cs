using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateProject.ViewModels
{
    public class AddEquipmentViewModel
    {
        public int CartonId { get; set; }
        public int EquipmentId { get; set; }

        public string  Error { get; set; }
    }
}