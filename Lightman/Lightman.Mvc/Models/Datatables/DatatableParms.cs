namespace Lightman.Mvc.Models.Datatables
{
    public class DatatableParms
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public string command { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public string airport { get; set; }

        public List<DatatableParmsOrder> order { get; set; }
        public DatatableParmsSearch search { get; set; }
    }

}
