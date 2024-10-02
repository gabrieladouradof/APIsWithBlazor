using Refit;

namespace BlazorGetTest.Client.Services;

public interface IGetApi
{
    [Get("/advice")]
    Task<SlipResponse> GetAdviceAsync();
}

public class SlipResponse
{
    public Slip? slip { get; set; }
}

public class Slip
{
    public int Id { get; set; }
    public string Advice { get; set; } = string.Empty;

}


//public class AdviceResponse
//{
//    public string Advice { get; set; } = string.Empty;
//}
 