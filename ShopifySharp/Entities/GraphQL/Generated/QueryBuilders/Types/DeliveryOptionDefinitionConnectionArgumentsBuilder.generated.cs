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
    public sealed class DeliveryOptionDefinitionConnectionArgumentsBuilder : ArgumentsBuilderBase<DeliveryOptionDefinitionConnection, DeliveryOptionDefinitionConnectionArgumentsBuilder>
    {
        protected override DeliveryOptionDefinitionConnectionArgumentsBuilder Self => this;

        public DeliveryOptionDefinitionConnectionArgumentsBuilder(IQuery<DeliveryOptionDefinitionConnection> query) : base(query)
        {
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder Active(bool? active)
        {
            base.InnerQuery.AddArgument("active", active);
            return this;
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryOptionDefinitionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}