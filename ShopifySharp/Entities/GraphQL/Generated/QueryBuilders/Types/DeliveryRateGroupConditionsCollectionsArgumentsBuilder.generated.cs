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
    public sealed class DeliveryRateGroupConditionsCollectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionConnection?, DeliveryRateGroupConditionsCollectionsArgumentsBuilder>
    {
        protected override DeliveryRateGroupConditionsCollectionsArgumentsBuilder Self => this;

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder(IQuery<CollectionConnection?> query) : base(query)
        {
        }

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryRateGroupConditionsCollectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}