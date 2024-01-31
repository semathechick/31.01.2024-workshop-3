

namespace Business.Abstract
{
    public interface IUsersService
    {
        public GetUsersListResponse GetList(GetUsersListRequest request);

        public AddUsersResponse Add(AddUsersRequest request);

    }
}
