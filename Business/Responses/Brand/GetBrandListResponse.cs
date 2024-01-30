

namespace Business;

public class GetBrandListResponse
{
    public ICollection<UsersListItemDto> Items { get; set; }

    public GetBrandListResponse()
    {
        Items = Array.Empty<UsersListItemDto>();
    }

    public GetBrandListResponse(ICollection<UsersListItemDto> items)
    {
        Items = items;
    }
}
