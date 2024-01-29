namespace ShowRoomManagmentAPI.DTOs
{
    public class ResponseDTO
    {
        public int StatusCode { get; set; }
        public string ErrorMassage { get; set; }
        public dynamic Response { get; set; }
    }
}
