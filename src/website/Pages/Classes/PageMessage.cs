using website.Enums;

namespace website.Pages.Classes
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
