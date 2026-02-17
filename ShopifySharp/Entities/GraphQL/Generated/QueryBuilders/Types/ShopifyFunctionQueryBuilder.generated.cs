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
    public sealed class ShopifyFunctionQueryBuilder : FieldsQueryBuilderBase<ShopifyFunction, ShopifyFunctionQueryBuilder>
    {
        protected override ShopifyFunctionQueryBuilder Self => this;

        public ShopifyFunctionQueryBuilder() : this("shopifyFunction")
        {
        }

        public ShopifyFunctionQueryBuilder(string name) : base(new Query<ShopifyFunction>(name))
        {
        }

        public ShopifyFunctionQueryBuilder(IQuery<ShopifyFunction> query) : base(query)
        {
        }

        public ShopifyFunctionQueryBuilder ApiType()
        {
            base.InnerQuery.AddField("apiType");
            return this;
        }

        public ShopifyFunctionQueryBuilder ApiVersion()
        {
            base.InnerQuery.AddField("apiVersion");
            return this;
        }

        public ShopifyFunctionQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public ShopifyFunctionQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public ShopifyFunctionQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public ShopifyFunctionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ShopifyFunctionQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ShopifyFunctionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyFunctionQueryBuilder InputQuery()
        {
            base.InnerQuery.AddField("inputQuery");
            return this;
        }

        public ShopifyFunctionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ShopifyFunctionQueryBuilder UseCreationUi()
        {
            base.InnerQuery.AddField("useCreationUi");
            return this;
        }
    }
}