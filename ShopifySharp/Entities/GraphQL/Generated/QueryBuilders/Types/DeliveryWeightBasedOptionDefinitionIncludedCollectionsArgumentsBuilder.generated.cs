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
    public sealed class DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionConnection?, DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder>
    {
        protected override DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder Self => this;

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder(IQuery<CollectionConnection?> query) : base(query)
        {
        }

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionIncludedCollectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}