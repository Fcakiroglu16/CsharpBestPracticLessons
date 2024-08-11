using Microsoft.AspNetCore.Mvc;

namespace ProblemDetails.API.Models
{
    public class CustomValidationProblemDetails:Microsoft.AspNetCore.Mvc.ProblemDetails
    {

        public Dictionary<string,List<string>> Errors { get; set; }


        public static CustomValidationProblemDetails AddError(string fieldName,string error)
        {

            var problemDetails = new CustomValidationProblemDetails
            {
                Type= "https://tools.ietf.org/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred.",
                Status = StatusCodes.Status400BadRequest,
                //Detail = "Validation errors occurred.",
                //Instance = $"urn:myorganization:badrequest:{Guid.NewGuid()}",
                Errors = new Dictionary<string, List<string>>()
            };

            if (problemDetails.Errors.ContainsKey(fieldName))
            {
                problemDetails.Errors[fieldName].Add(error);
            }
            else
            {
                problemDetails.Errors.Add(fieldName, [error]);
            }

            return problemDetails;

        }

        //error list
        public static CustomValidationProblemDetails AddErrors(Dictionary<string,string> errors)
        {
            var problemDetails = new CustomValidationProblemDetails
            {
                Title = "One or more validation errors occurred.",
                Status = StatusCodes.Status400BadRequest,
                Detail = "Validation errors occurred.",
                Instance = $"urn:myorganization:badrequest:{Guid.NewGuid()}",
                Errors = new Dictionary<string, List<string>>()
            };

            foreach (var error in errors)
            {
                if (problemDetails.Errors.ContainsKey(error.Key))
                {
                    problemDetails.Errors[error.Key].Add(error.Value);
                }
                else
                {
                    problemDetails.Errors.Add(error.Key, [error.Value]);
                }
            }

            return problemDetails;
        }
    }
}
