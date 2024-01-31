using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;

using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class UsersManager : IUsersService
{
    private readonly IUserDal _userDal;
    private readonly UsersBusinessRules _usersBusinessRules;
    private readonly IMapper _mapper;

    public UsersManager(IUserDal userDal, UsersBusinessRules usersBusinessRules, IMapper mapper)
    {
        _userDal = userDal; 
        _usersBusinessRules = usersBusinessRules;
        _mapper = mapper;
    }

    public AddUsersResponse Add(AddUsersRequest request)
    {
       
        _usersBusinessRules.CheckIfUserNameExists(request.FirstName);
        _usersBusinessRules.CheckIfUserLastNameExists(request.LastName);
        _usersBusinessRules.CheckIfUserNameLengthIsLongerThan1Letter(request.FirstName);
        _usersBusinessRules.CheckIfUserNameLengthIsShorterThan50Letters(request.LastName);  
       
        User userToAdd = _mapper.Map<User>(request); 

        _userDal.Add(userToAdd);

        AddUsersResponse response = _mapper.Map<AddUsersResponse>(userToAdd);
        return response;
    }

    public GetUsersListResponse GetList(GetUsersListRequest request)
    {
        

        IList<User> userList = _userDal.GetList();

       

        GetUsersListResponse response = _mapper.Map<GetUsersListResponse>(userList); // Mapping
        return response;
    }
}

