using System;
namespace NeoHC.Users.Models
{
    public class User
    {
        public User(
            Guid id,
            Guid employeeId,
            string email)
        {
            Id = id;
            EmployeeId = employeeId;
            Email = email;
        }

        public Guid Id { get; }

        public Guid EmployeeId { get; }

        public string Email { get; }
    }
}
