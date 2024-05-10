using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp;

public class ShopifyPaymentsDisputeEvidenceProductDescription
{
    [JsonProperty("Product name")]
    public string ProductName { get; set; }
    public string Title { get; set; }
    public string Price { get; set; }
    public string Quantity { get; set; }

    [JsonProperty("Product Description")]
    public string ProductDescription { get; set; }
}