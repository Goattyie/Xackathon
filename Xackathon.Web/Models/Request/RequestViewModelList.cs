namespace Xackathon.Web.Models
{
    public class RequestViewModelList
    {
        public int Total { get; set; }
        public IEnumerable<RequestViewModel> Data { get; set; }
    }
}
