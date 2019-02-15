using Vehicles.Web.Enums;

namespace Vehicles.Web.Pages.Classes
{
    public class PageMessage
    {
        public PageMessage(MessageType type, string text)
        {
            Type = type;
            Text = text;
        }

        public MessageType Type { get; set; }
        public string Text { get; set; }
    }
}
