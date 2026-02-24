#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SellingPlanMetafieldDefinitionsArgumentsBuilder : ArgumentsBuilderBase<MetafieldDefinitionConnection?, SellingPlanMetafieldDefinitionsArgumentsBuilder>
    {
        protected override SellingPlanMetafieldDefinitionsArgumentsBuilder Self => this;

        public SellingPlanMetafieldDefinitionsArgumentsBuilder(IQuery<MetafieldDefinitionConnection?> query) : base(query)
        {
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder PinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
        {
            base.InnerQuery.AddArgument("pinnedStatus", pinnedStatus);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public SellingPlanMetafieldDefinitionsArgumentsBuilder SortKey(MetafieldDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}