using ApiPneuStore.API;
using Microsoft.AspNetCore.Mvc;

namespace ApiPneuStore.Controllers
{
    public abstract class ApiBaseController : ControllerBase
    {

        #region privateMethods
        APIResponse<T> CustomResponse<T>(T Results, bool Succeed = true, string Message = "") =>
            new APIResponse<T>()
            {
                Results = Results,
                Succeed = Succeed,
                Message = Message
            };

        APIResponse<string> CustomResponse(bool Succeed = true, string Message = "") =>
            new APIResponse<string>()
            {
                Succeed = Succeed,
                Message = Message
            };

        #endregion privateMethods
    
        protected OkObjectResult ApiOk<T>(T Results) =>
          Ok(CustomResponse(Results));

        protected OkObjectResult ApiOk(string Message = "") =>
            Ok(CustomResponse(true, Message));

        protected NotFoundObjectResult ApiNotFound(string Message) =>
            NotFound(CustomResponse(false, Message));

        protected BadRequestObjectResult ApiBadRequest<T>(T Results, string Message = "") =>
            BadRequest(CustomResponse(Results, false, Message));
    }
}
