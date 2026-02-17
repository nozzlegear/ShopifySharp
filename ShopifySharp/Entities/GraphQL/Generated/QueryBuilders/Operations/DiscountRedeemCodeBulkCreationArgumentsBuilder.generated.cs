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
    public sealed class DiscountRedeemCodeBulkCreationArgumentsBuilder : ArgumentsBuilderBase<DiscountRedeemCodeBulkCreation, DiscountRedeemCodeBulkCreationArgumentsBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationArgumentsBuilder Self => this;

        public DiscountRedeemCodeBulkCreationArgumentsBuilder(IQuery<DiscountRedeemCodeBulkCreation> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}