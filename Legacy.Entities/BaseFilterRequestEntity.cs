namespace Legacy.Entities
{
    public class BaseFilterRequestEntity
    {
        public int FirstRec { get; set; }
        public int LastRec { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public string OrderBy { get; set; }
        public string SearchByText { get; set; }
        public string SearchByValue { get; set; }
    }
}
