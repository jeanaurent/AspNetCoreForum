using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreForum.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category  { get; set; }
        public string Author  { get; set; }
        public string Subject  { get; set; }
        public string Content  { get; set; }
        public string Status  { get; set; }
    }
}
