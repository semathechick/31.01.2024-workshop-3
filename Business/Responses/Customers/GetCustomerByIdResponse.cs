﻿namespace Business
{
    public class GetCustomerByIdResponse
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


    }
}