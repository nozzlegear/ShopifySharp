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
    public sealed class MoneyBagQueryBuilder : FieldsQueryBuilderBase<MoneyBag, MoneyBagQueryBuilder>, IHasArguments<MoneyBagArgumentsBuilder>
    {
        public MoneyBagArgumentsBuilder Arguments { get; }
        protected override MoneyBagQueryBuilder Self => this;

        public MoneyBagQueryBuilder() : this("moneyBag")
        {
        }

        public MoneyBagQueryBuilder(string name) : base(new Query<MoneyBag>(name))
        {
            Arguments = new MoneyBagArgumentsBuilder(base.InnerQuery);
        }

        public MoneyBagQueryBuilder(IQuery<MoneyBag> query) : base(query)
        {
            Arguments = new MoneyBagArgumentsBuilder(base.InnerQuery);
        }

        public MoneyBagQueryBuilder SetArguments(Action<MoneyBagArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MoneyBagQueryBuilder PresentmentMoney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("presentmentMoney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public MoneyBagQueryBuilder ShopMoney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("shopMoney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}