namespace BlabberApp.Domain
{
    public class Blab : IDatum
    {
        private System.DateTime timeStamp { get; set; }
        private string message { get; set; }
        private string UserId { get; set; }

        public string getsysid()
        {
            return "";
        }
    }
}