using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiApi.DTO
{
    public class SendPostDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
    }
}
