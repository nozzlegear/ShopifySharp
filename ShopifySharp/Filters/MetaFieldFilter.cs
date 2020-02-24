using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
	/// <summary>
	/// Options for filtering <see cref="MetaFieldService.CountAsync(long?, string, MetaFieldFilter)"/> and 
	/// <see cref="MetaFieldService.ListAsync(long?, string, MetaFieldFilter)"/> results.
	/// </summary>
	public class MetaFieldFilter : ListFilter
	{
		/// <summary>
		/// Filter by namespace.
		/// </summary>
		[JsonProperty("namespace")]
		public string Namespace { get; set; }

		/// <summary>
		/// Filter by key value.
		/// </summary>
		[JsonProperty("key")]
		public string Key { get; set; }

		/// <summary>
		/// Filter by value_type.
		/// </summary>
		[JsonProperty("value_type")]
		public string ValueType { get; set; }

		/// <summary>
		/// A comma-separated list of fields to include in the response
		/// </summary>
		[JsonProperty("fields")]
		public string Fields { get; set; }

		/// <summary>
		/// Show metafields created after date
		/// </summary>
		[JsonProperty("created_at_min")] 
		public DateTimeOffset? CreatedAtMin { get; set; }

		/// <summary>
		/// Show metafields created before date
		/// </summary>
		[JsonProperty("created_at_max")] 
		public DateTimeOffset? CreatedAtMax { get; set; }

		/// <summary>
		/// Show metafields last updated after date
		/// </summary>
		[JsonProperty("updated_at_min")]
		public DateTimeOffset? UpdatedAtMin { get; set; }

		/// <summary>
		/// Show metafields last updated before date 
		/// </summary>
        [JsonProperty("updated_at_max")]
		public DateTimeOffset UpdatedAtMax { get; set; }
	}
}
