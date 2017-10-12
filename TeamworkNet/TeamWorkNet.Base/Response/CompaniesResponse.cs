﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeamWorkNet.Model;

namespace TeamWorkNet.Response
{
  public class CompaniesResponse
  {
    [JsonProperty("companies")]
    public List<Company> Companies { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }
}
