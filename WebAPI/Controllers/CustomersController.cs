using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Customers;
using Business.Responses.Customers;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService; // Field

    public CustomersController(ICustomerService customerService)
    {
       
        _customerService = customerService;
      
    }


    [HttpGet] 
    public GetCustomerListResponse GetList([FromQuery] GetCustomerListRequest request) 
    {
        GetCustomerListResponse response = _customerService.GetList(request);
        return response; 
    }

    [HttpGet("{Id}")] 
    public GetCustomerByIdResponse GetById([FromRoute] GetCustomerByIdRequest request)
    {
        GetCustomerByIdResponse response = _customerService.GetById(request);
        return response;
    }

    [HttpPost] 
    public ActionResult<AddCustomerResponse> Add(AddCustomerRequest request)
    {
        try
        {
            AddCustomerResponse response = _customerService.Add(request);

       
            return CreatedAtAction(nameof(GetList), response); 
        }
        catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
        {
            return BadRequest(
                new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                {
                    Title = "Business Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = exception.Message,
                    Instance = HttpContext.Request.Path
                }
            );
          
        }
    }
}

