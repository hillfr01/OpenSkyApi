namespace Lightman.Mvc.Models.Datatables
{
    public class ResultListWrapper<T>
    {
        public ResultListWrapper(List<T> list, int totalCount)
        {
            Items = list;
            TotalCount = totalCount;
        }
        public int TotalCount { get; set; }

        public ResultListWrapper(IList<T> items)
        {
            Items = items;
            TotalCount = items.Count;
        }

        public IList<T> Items { get; set; }

    }
}
