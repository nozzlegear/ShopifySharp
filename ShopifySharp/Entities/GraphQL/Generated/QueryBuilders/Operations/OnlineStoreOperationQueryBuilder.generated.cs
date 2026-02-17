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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class OnlineStoreOperationQueryBuilder : FieldsQueryBuilderBase<OnlineStore, OnlineStoreOperationQueryBuilder>, IGraphOperationQueryBuilder<OnlineStore>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override OnlineStoreOperationQueryBuilder Self => this;

        public OnlineStoreOperationQueryBuilder() : this("onlineStore")
        {
        }

        public OnlineStoreOperationQueryBuilder(string name) : base(new Query<OnlineStore>(name))
        {
        }

        public OnlineStoreOperationQueryBuilder(IQuery<OnlineStore> query) : base(query)
        {
        }

        public OnlineStoreOperationQueryBuilder PasswordProtection(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStorePasswordProtectionQueryBuilder> build)
        {
            var query = new Query<OnlineStorePasswordProtection>("passwordProtection");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStorePasswordProtectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStorePasswordProtection>(query);
            return this;
        }
    }
}