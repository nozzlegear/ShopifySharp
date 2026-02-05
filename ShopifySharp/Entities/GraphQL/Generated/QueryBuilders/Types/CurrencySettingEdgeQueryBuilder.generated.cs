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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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

        public CurrencySettingEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingQueryBuilder> build)
        {
            var query = new Query<CurrencySetting>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySetting>(query);
            return this;
        }
    }
}