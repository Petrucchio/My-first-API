namespace API_User.Models
{
    public class ValidationViewModelOutput
    {
        public IEnumerable<string> Errors { get; private set; }
        public ValidationViewModelOutput(IEnumerable<string> errors)
        {
            Errors = errors;
        }
    }
}
