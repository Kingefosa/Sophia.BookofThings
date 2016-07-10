namespace Sophia.BookofThings.Commands
{
    public class BeginCheckList : ICommand
    {
        public BeginCheckList(string title, string[] items)
        {
            Title = title;
            Items = items;
        }
        public string Title { get; }
        public string[] Items { get; }
    }
}