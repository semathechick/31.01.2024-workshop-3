using Business;
using Business.Abstract;
using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IndividualCustomerController : ControllerBase
{
    private readonly IIndividualCustomerService _individualCustomerService; // Field

    public IndividualCustomerController(IIndividualCustomerService individualCustomerService)
    {

        _individualCustomerService = individualCustomerService;

    }


    [HttpGet]
    public GetIndividualCustomerListResponse GetList([FromQuery] GetIndividualCustomerListRequest request)
    {
        GetIndividualCustomerListResponse response = _individualCustomerService.GetList(request);
        return response;
    }

    [HttpGet("{Id}")]
    public GetIndividualCustomerByIdResponse GetById([FromRoute] GetIndividualCustomerByIdRequest request)
    {
        GetIndividualCustomerByIdResponse response = _individualCustomerService.GetById(request);
        return response;
    }

    [HttpPost]
    public ActionResult<AddIndividualCustomerResponse> Add(AddIndividualCustomerRequest request)
    {
        try
        {
            AddIndividualCustomerResponse response = _individualCustomerService.Add(request);


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


