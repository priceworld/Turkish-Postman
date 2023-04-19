using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiApi
{
    public class GoodsIN
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("BusinessType")]
        public string? BusinessType { get; set; }
        [JsonProperty("TaskType")]
        public string? TaskType { get; set; }
        [JsonProperty("OrderCode")]
        public string? OrderCode { get; set; }
        [JsonProperty("OrderDate")]
        public DateTime? OrderDate { get; set; }
        [JsonProperty("OrderGroupNo")]
        public string? OrderGroupNo { get; set; }
        [JsonProperty("OrderGroupValue")]
        public string? OrderGroupValue { get; set; }
        [JsonProperty("CreatedDate")]
        public DateTime? CreatedDate { get; set; }
        [JsonProperty("IsActive")]
        public string? IsActive { get; set; }
        [JsonProperty("IsComplated")]
        public string? IsComplated { get; set; }
        [JsonProperty("Eta")]
        public DateTime? Eta { get; set; }
        [JsonProperty("Etd")]
        public DateTime? Etd { get; set; }
        [JsonProperty("ControlWeight")]
        public int? ControlWeight { get; set; }
        [JsonProperty("ControlHeight")]
        public int? ControlHeight { get; set; }
        [JsonProperty("AllocationMethodId")]
        public int? AllocationMethodId { get; set; }
        [JsonProperty("OrgCodeId")]
        public int? OrgCodeId { get; set; }
        [JsonProperty("AccountId")]
        public int? AccountId { get; set; }
        [JsonProperty("PriorityId")]
        public int? PriorityId { get; set; }
        [JsonProperty("CreatedUserId")]
        public int? CreatedUserId { get; set; }
        [JsonProperty("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }
        [JsonProperty("UpdatedUserId")]
        public int? UpdatedUserId { get; set; }
        [JsonProperty("Status")]
        public int? Status { get; set; }
    }
}
