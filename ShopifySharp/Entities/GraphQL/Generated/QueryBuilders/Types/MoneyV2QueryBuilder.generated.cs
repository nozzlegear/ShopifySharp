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
    public sealed class MoneyV2QueryBuilder : FieldsQueryBuilderBase<MoneyV2, MoneyV2QueryBuilder>
    {
        protected override MoneyV2QueryBuilder Self => this;

        public MoneyV2QueryBuilder() : this("moneyV2")
        {
        }

        public MoneyV2QueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
        }

        public MoneyV2QueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
        }

        public MoneyV2QueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public MoneyV2QueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }
    }
}