﻿namespace webblogapi.DTOs
{
    public class UserDTO
    {
        public string UserId { get; set; } = null!;

        public string Fullname { get; set; } = null!;

        public string? Describe { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? Avatar { get; set; }

        public int? IsActive { get; set; }
    }
}
