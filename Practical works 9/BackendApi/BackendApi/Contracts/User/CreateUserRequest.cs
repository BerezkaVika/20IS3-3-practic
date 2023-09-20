namespace BackendApi.Contracts.User
{
    public class CreateUserRequest
    {
     

        public DateTime RegDate { get; set; }

        public string Login { get; set; } = null!;      

        public string Password { get; set; } = null!;

        public bool IsDeleted { get; set; }
        
        public int Role { get; set; }

    }
}
