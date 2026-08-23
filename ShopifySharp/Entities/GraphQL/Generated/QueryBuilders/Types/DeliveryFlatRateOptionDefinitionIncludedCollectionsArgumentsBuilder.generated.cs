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
    public sealed class DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionConnection?, DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder>
    {
        protected override DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder Self => this;

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder(IQuery<CollectionConnection?> query) : base(query)
        {
        }

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionIncludedCollectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}