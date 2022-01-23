namespace Xackathon.Web.Models
{
    public class RequestViewModel
    {
        public int Total { get; set; }
        public IEnumerable<RequestObjectViewModel> Data { get; set; }
    }
}
