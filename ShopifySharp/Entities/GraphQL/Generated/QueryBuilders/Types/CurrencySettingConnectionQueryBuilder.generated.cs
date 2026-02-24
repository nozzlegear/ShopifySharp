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
    public sealed class CurrencySettingConnectionQueryBuilder : FieldsQueryBuilderBase<CurrencySettingConnection, CurrencySettingConnectionQueryBuilder>, IHasArguments<CurrencySettingConnectionArgumentsBuilder>
    {
        public CurrencySettingConnectionArgumentsBuilder Arguments { get; }
        protected override CurrencySettingConnectionQueryBuilder Self => this;

        public CurrencySettingConnectionQueryBuilder() : this("currencySettingConnection")
        {
        }

        public CurrencySettingConnectionQueryBuilder(string name) : base(new Query<CurrencySettingConnection>(name))
        {
            Arguments = new CurrencySettingConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CurrencySettingConnectionQueryBuilder(IQuery<CurrencySettingConnection> query) : base(query)
        {
            Arguments = new CurrencySettingConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CurrencySettingConnectionQueryBuilder SetArguments(Action<CurrencySettingConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CurrencySettingConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingEdgeQueryBuilder> build)
        {
            var query = new Query<CurrencySettingEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySettingEdge>(query);
            return this;
        }

        public CurrencySettingConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder> build)
        {
            var query = new Query<CurrencySetting>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySetting>(query);
            return this;
        }

        public CurrencySettingConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}