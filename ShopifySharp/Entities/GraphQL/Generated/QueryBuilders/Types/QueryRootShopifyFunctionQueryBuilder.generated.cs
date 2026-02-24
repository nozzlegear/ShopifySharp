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
    public sealed class QueryRootShopifyFunctionQueryBuilder : FieldsQueryBuilderBase<ShopifyFunction, QueryRootShopifyFunctionQueryBuilder>, IHasArguments<QueryRootShopifyFunctionArgumentsBuilder>
    {
        public QueryRootShopifyFunctionArgumentsBuilder Arguments { get; }
        protected override QueryRootShopifyFunctionQueryBuilder Self => this;

        public QueryRootShopifyFunctionQueryBuilder(string name) : base(new Query<ShopifyFunction>(name))
        {
            Arguments = new QueryRootShopifyFunctionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyFunctionQueryBuilder(IQuery<ShopifyFunction> query) : base(query)
        {
            Arguments = new QueryRootShopifyFunctionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyFunctionQueryBuilder SetArguments(Action<QueryRootShopifyFunctionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder ApiType()
        {
            base.InnerQuery.AddField("apiType");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder ApiVersion()
        {
            base.InnerQuery.AddField("apiVersion");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder InputQuery()
        {
            base.InnerQuery.AddField("inputQuery");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootShopifyFunctionQueryBuilder UseCreationUi()
        {
            base.InnerQuery.AddField("useCreationUi");
            return this;
        }
    }
}