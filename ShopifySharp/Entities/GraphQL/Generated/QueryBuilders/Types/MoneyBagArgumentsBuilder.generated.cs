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
    public sealed class MoneyBagArgumentsBuilder : ArgumentsBuilderBase<MoneyBag, MoneyBagArgumentsBuilder>
    {
        protected override MoneyBagArgumentsBuilder Self => this;

        public MoneyBagArgumentsBuilder(IQuery<MoneyBag> query) : base(query)
        {
        }

        public MoneyBagArgumentsBuilder WithCodeDiscounts(bool? withCodeDiscounts)
        {
            base.InnerQuery.AddArgument("withCodeDiscounts", withCodeDiscounts);
            return this;
        }
    }
}