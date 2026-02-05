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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ShopifyFunctionOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyFunction, ShopifyFunctionOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyFunction>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ShopifyFunctionArgumentsBuilder Arguments { get; }
        protected override ShopifyFunctionOperationQueryBuilder Self => this;

        public ShopifyFunctionOperationQueryBuilder() : this("shopifyFunction")
        {
        }

        public ShopifyFunctionOperationQueryBuilder(string name) : base(new Query<ShopifyFunction>(name))
        {
            Arguments = new ShopifyFunctionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyFunctionOperationQueryBuilder(IQuery<ShopifyFunction> query) : base(query)
        {
            Arguments = new ShopifyFunctionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyFunctionOperationQueryBuilder ApiType()
        {
            base.InnerQuery.AddField("apiType");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder ApiVersion()
        {
            base.InnerQuery.AddField("apiVersion");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder InputQuery()
        {
            base.InnerQuery.AddField("inputQuery");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ShopifyFunctionOperationQueryBuilder UseCreationUi()
        {
            base.InnerQuery.AddField("useCreationUi");
            return this;
        }
    }
}