using API_User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API_User.Filters
{
    public class ValidationModelStateCustomized : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validationViewModel = new ValidationViewModelOutput(context.ModelState.SelectMany(selectmany => selectmany.Value.Errors).Select(select => select.ErrorMessage));
                context.Result = new BadRequestObjectResult(validationViewModel);
            }
        }
    }
}
