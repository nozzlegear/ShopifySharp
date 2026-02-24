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
    public sealed class DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder : ArgumentsBuilderBase<DeliveryMethodDefinitionConnection?, DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder>
    {
        protected override DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Self => this;

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder(IQuery<DeliveryMethodDefinitionConnection?> query) : base(query)
        {
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Eligible(bool? eligible)
        {
            base.InnerQuery.AddArgument("eligible", eligible);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder SortKey(MethodDefinitionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Type(DeliveryMethodDefinitionType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}