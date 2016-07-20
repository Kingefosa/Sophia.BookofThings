namespace Sophia.BookofThings.Commands
{
    public class BeginChecklist : ICommand
    {
        public BeginChecklist(string title, string[] items)
        {
            Title = title;
            Items = items;
        }
        public string Title { get; }
        public string[] Items { get; }
    }
}