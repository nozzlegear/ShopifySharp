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
    public sealed class DeliveryMethodDefinitionConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryMethodDefinitionConnection, DeliveryMethodDefinitionConnectionArgumentsBuilder>
    {
        protected override DeliveryMethodDefinitionConnectionArgumentsBuilder Self => this;

        public DeliveryMethodDefinitionConnectionArgumentsBuilder(IQuery<DeliveryMethodDefinitionConnection> query) : base(query)
        {
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder Eligible(bool? eligible)
        {
            base.InnerQuery.AddArgument("eligible", eligible);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder SortKey(MethodDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public DeliveryMethodDefinitionConnectionArgumentsBuilder Type(DeliveryMethodDefinitionType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}