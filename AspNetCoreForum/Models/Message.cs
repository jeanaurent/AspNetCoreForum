using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreForum.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string category  { get; set; }
        public string author  { get; set; }
        public string subject  { get; set; }
        public string content  { get; set; }
        public string status  { get; set; }
    }
}
