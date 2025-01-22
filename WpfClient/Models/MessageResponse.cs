using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public class MessageResponse
    {
        public int Code { get; set; }
        public MessageItemResponse? Data { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
