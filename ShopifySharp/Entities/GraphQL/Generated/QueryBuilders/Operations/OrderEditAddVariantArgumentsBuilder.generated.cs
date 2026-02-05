#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class OrderEditAddVariantArgumentsBuilder : ArgumentsBuilderBase<OrderEditAddVariantPayload, OrderEditAddVariantArgumentsBuilder>
    {
        protected override OrderEditAddVariantArgumentsBuilder Self => this;

        public OrderEditAddVariantArgumentsBuilder(IQuery<OrderEditAddVariantPayload> query) : base(query)
        {
        }

        public OrderEditAddVariantArgumentsBuilder AllowDuplicates(bool? allowDuplicates)
        {
            base.InnerQuery.AddArgument("allowDuplicates", allowDuplicates);
            return this;
        }

        public OrderEditAddVariantArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditAddVariantArgumentsBuilder LocationId(string? locationId)
        {
            base.InnerQuery.AddArgument("locationId", locationId);
            return this;
        }

        public OrderEditAddVariantArgumentsBuilder Quantity(int? quantity)
        {
            base.InnerQuery.AddArgument("quantity", quantity);
            return this;
        }

        public OrderEditAddVariantArgumentsBuilder VariantId(string? variantId)
        {
            base.InnerQuery.AddArgument("variantId", variantId);
            return this;
        }
    }
}