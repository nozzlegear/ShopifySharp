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
    public sealed class DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionConnection?, DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder>
    {
        protected override DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder Self => this;

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder(IQuery<CollectionConnection?> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionIncludedCollectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}