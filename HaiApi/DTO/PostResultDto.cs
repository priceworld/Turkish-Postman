using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiApi.DTO
{
    public class PostResultDto
    {
        public long id { get; set; }
        public string? OrderCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? OrderGroupNo { get; set; }
        public string? OrderGroupValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? IsActive { get; set; }
        public string? IsComplated { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Etd { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public int? Status { get; set; }
    }
}
