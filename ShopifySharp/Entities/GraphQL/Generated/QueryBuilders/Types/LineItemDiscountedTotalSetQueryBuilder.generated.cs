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
    public sealed class LineItemDiscountedTotalSetQueryBuilder : FieldsQueryBuilderBase<MoneyBag, LineItemDiscountedTotalSetQueryBuilder>, IHasArguments<LineItemDiscountedTotalSetArgumentsBuilder>
    {
        public LineItemDiscountedTotalSetArgumentsBuilder Arguments { get; }
        protected override LineItemDiscountedTotalSetQueryBuilder Self => this;

        public LineItemDiscountedTotalSetQueryBuilder(string name) : base(new Query<MoneyBag>(name))
        {
            Arguments = new LineItemDiscountedTotalSetArgumentsBuilder(base.InnerQuery);
        }

        public LineItemDiscountedTotalSetQueryBuilder(IQuery<MoneyBag> query) : base(query)
        {
            Arguments = new LineItemDiscountedTotalSetArgumentsBuilder(base.InnerQuery);
        }

        public LineItemDiscountedTotalSetQueryBuilder SetArguments(Action<LineItemDiscountedTotalSetArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public LineItemDiscountedTotalSetQueryBuilder PresentmentMoney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("presentmentMoney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public LineItemDiscountedTotalSetQueryBuilder ShopMoney(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("shopMoney");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}