using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public class MessageItemResponse
    {
        public int MessageId { get; set; }
        public int CampaignId { get; set; }
        public int Status { get; set; }
    }
}
