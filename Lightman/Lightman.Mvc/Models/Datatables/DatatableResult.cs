namespace Lightman.Mvc.Models.Datatables
{
    public class DatatableResult
    {
        public int draw { get; set; }
        public int recordsFiltered { get; set; }
        public int recordsTotal { get; set; }
        public IEnumerable<object> data { get; set; }
    }
}
