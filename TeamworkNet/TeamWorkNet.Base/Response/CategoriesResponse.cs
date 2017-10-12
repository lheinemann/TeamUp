﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeamWorkNet.Model;

namespace TeamWorkNet.Response
{
  public class CategoriesResponse
  {
    [JsonProperty("categories")]
    public List<Category> Categories { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }

  public class CategoryResponse
  {
    [JsonProperty("category")]
    public Category Category { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }

}
