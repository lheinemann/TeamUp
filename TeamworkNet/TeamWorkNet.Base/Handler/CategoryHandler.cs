using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeamWorkNet.Base;
using TeamWorkNet.Model;
using TeamWorkNet.Response;

namespace TeamWorkNet.Handler
{
  public class CategoryHandler
  {
    private readonly TeamWorkClient _client;
    public CategoryHandler(TeamWorkClient client)
    {
      _client = client;
    }


    public async Task<CategoriesResponse> GetProjectCategoriesAsync()
    {
      using (var client = new AuthorizedHttpClient(_client))
      {
        var data = await client.GetAsync<CategoriesResponse>("projectCategories.json", null);
        if (data.StatusCode == HttpStatusCode.OK) return (CategoriesResponse)data.ContentObj;
      }
      return new CategoriesResponse() { STATUS = "ERROR", Categories = null };
    }

    public async Task<bool> AddProjectCategory(Category company)
    {
      using (var client = new AuthorizedHttpClient(_client))
      {
        string post = JsonConvert.SerializeObject(company);
        var response = await client.PostAsync("categories.json", new StringContent("{\"category\":" + post + "}", Encoding.UTF8));
      }
      return false;
    }

    public async Task<bool> UpdateProjectCategory(Category company)
    {
      using (var client = new AuthorizedHttpClient(_client))
      {
        string post = JsonConvert.SerializeObject(company);
        var response =
          await client.PutAsync("/category/" + company.Id + ".json", new StringContent("{\"category\":" + post + "}", Encoding.UTF8));
      }
      return false;
    }

    public async Task<bool> DeleteCProjectCategory(Category company)
    {
      using (var client = new AuthorizedHttpClient(_client))
      {
        string post = JsonConvert.SerializeObject(company);
        var response = await client.DeleteAsync("/category/" + company.Id + ".json");
      }
      return false;
    }

  }
}
