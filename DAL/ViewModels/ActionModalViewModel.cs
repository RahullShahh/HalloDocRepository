using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class ActionModalViewModel
    {
        public string region {  get; set; }
        public string physician {  get; set; }
        public string description {  get; set; }
        public string blockReason {  get; set; }
        public string cancellationReason {  get; set; }
        public string additionalNotes {  get; set; }
        public string ptFirstName {  get; set; }
        public string ptLastName { get; set; }
    }
}
