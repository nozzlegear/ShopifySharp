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
    public sealed class CurrencySettingEdgeQueryBuilder : FieldsQueryBuilderBase<CurrencySettingEdge, CurrencySettingEdgeQueryBuilder>
    {
        protected override CurrencySettingEdgeQueryBuilder Self => this;

        public CurrencySettingEdgeQueryBuilder() : this("currencySettingEdge")
        {
        }

        public CurrencySettingEdgeQueryBuilder(string name) : base(new Query<CurrencySettingEdge>(name))
        {
        }

        public CurrencySettingEdgeQueryBuilder(IQuery<CurrencySettingEdge> query) : base(query)
        {
        }

        public CurrencySettingEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CurrencySettingEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder> build)
        {
            var query = new Query<CurrencySetting>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySetting>(query);
            return this;
        }
    }
}