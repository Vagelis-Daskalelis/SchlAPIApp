﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using SchlAPIApp.Models;

namespace SchlAPIApp.DTO
{
    public class UserReadOnlyDTO
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public UserRole? UserRole { get; set; }
    }
}
