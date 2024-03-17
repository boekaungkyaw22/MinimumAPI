using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MinimumAPI.Models.Repository;

namespace MinimumAPI.Filter
{
    public class Shirt_ValidateShirtIdFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirtId = context.ActionArguments["id"] as int?;

            if  (shirtId.HasValue)
            {
                if (shirtId.Value <=0)
                {
                    context.ModelState.AddModelError("ShirtId", "ShirtId is invalid");
                    var problemDetail = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetail);
                }
                else if (!ShirtRepository.ShirtExist(shirtId.Value)) {
                    context.ModelState.AddModelError("ShirtId", "ShirtId doesn't exist");
                    var problemDetail = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new NotFoundObjectResult(problemDetail);
                }
            }
        }
    }
}
