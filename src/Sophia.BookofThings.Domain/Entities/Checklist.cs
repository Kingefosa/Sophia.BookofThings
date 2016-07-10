namespace Sophia.BookofThings.Entities
{
    using System;

    internal class Checklist
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public ChecklistItem[] ChecklistItems { get; set; }
    }

    internal class ChecklistItem
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
    }
}