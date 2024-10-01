using Refit;

namespace BlazorGetTest.Client.Services
{
    public interface IGetApi
    {
        [Get("/advice")]
        Task<AdviceResponse> GetAdviceAsync();
    }

    public class AdviceResponse
    {
        public string Advice { get; set; } = string.Empty;
    }
}
