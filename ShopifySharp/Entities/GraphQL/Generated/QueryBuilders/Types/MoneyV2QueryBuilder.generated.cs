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
    public sealed class MoneyV2QueryBuilder : FieldsQueryBuilderBase<MoneyV2, MoneyV2QueryBuilder>, IHasArguments<MoneyV2ArgumentsBuilder>
    {
        public MoneyV2ArgumentsBuilder Arguments { get; }
        protected override MoneyV2QueryBuilder Self => this;

        public MoneyV2QueryBuilder() : this("moneyV2")
        {
        }

        public MoneyV2QueryBuilder(string name) : base(new Query<MoneyV2>(name))
        {
            Arguments = new MoneyV2ArgumentsBuilder(base.InnerQuery);
        }

        public MoneyV2QueryBuilder(IQuery<MoneyV2> query) : base(query)
        {
            Arguments = new MoneyV2ArgumentsBuilder(base.InnerQuery);
        }

        public MoneyV2QueryBuilder SetArguments(Action<MoneyV2ArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
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