using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Constants;

namespace WpfClient.Models
{
    public class MessagePostRequests
    {
        public string Recipient { get; set; } = String.Empty;
        public string Text {  get; set; } = String.Empty;
    }
}
