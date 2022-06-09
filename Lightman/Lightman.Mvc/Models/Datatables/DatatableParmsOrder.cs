namespace Lightman.Mvc.Models.Datatables
{
    public class DatatableParmsOrder
    {
        public int column { get; set; }
        public string dir { get; set; } //"asc" or "desc"

        public const string asc = "asc";
        public const string desc = "desc";
    }
}
