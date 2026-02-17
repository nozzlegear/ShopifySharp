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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class OrderEditAddCustomItemArgumentsBuilder : ArgumentsBuilderBase<OrderEditAddCustomItemPayload, OrderEditAddCustomItemArgumentsBuilder>
    {
        protected override OrderEditAddCustomItemArgumentsBuilder Self => this;

        public OrderEditAddCustomItemArgumentsBuilder(IQuery<OrderEditAddCustomItemPayload> query) : base(query)
        {
        }

        public OrderEditAddCustomItemArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder Price(MoneyInput? price)
        {
            base.InnerQuery.AddArgument("price", price);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder Quantity(int? quantity)
        {
            base.InnerQuery.AddArgument("quantity", quantity);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder RequiresShipping(bool? requiresShipping)
        {
            base.InnerQuery.AddArgument("requiresShipping", requiresShipping);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder Taxable(bool? taxable)
        {
            base.InnerQuery.AddArgument("taxable", taxable);
            return this;
        }

        public OrderEditAddCustomItemArgumentsBuilder Title(string? title)
        {
            base.InnerQuery.AddArgument("title", title);
            return this;
        }
    }
}