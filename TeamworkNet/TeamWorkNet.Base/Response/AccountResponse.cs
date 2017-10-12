using Newtonsoft.Json;
using TeamWorkNet.Model;

namespace TeamWorkNet.Response
{
  public class AccountResponse
  {

    [JsonProperty("STATUS")]
    public string Status { get; set; }

    [JsonProperty("account")]
    public Account Account { get; set; }
  }
}