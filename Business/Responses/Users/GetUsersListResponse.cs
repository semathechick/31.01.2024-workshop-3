﻿using Business.Dtos.Brand;

namespace Business
{
    public class GetUsersListResponse
    {
        public ICollection<UsersListItemDto> Items { get; set; }

        public GetUsersListResponse()
        {
            Items = Array.Empty<UsersListItemDto>();
        }

        public GetUsersListResponse(ICollection<UsersListItemDto> items)
        {
            Items = items;
        }
    }
}