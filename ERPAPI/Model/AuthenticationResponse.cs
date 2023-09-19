namespace ERPAPI.Model
{
    public class AuthenticationResponse
    {
        public AuthenticationStatus Status { get; set; }
        public string? Message { get; set; }
    }


    public enum AuthenticationStatus
    {
        Success = 1,
        UserNotFound = 2,
        InvalidPassword = 3,
        AlreadyExists = 4,
        InternalServerError = 5,
        DepartmentNotFound = 6
    }
}
