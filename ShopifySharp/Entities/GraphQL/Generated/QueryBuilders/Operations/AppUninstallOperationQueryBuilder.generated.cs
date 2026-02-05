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
    public sealed class AppUninstallOperationQueryBuilder : FieldsQueryBuilderBase<AppUninstallPayload, AppUninstallOperationQueryBuilder>, IGraphOperationQueryBuilder<AppUninstallPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        protected override AppUninstallOperationQueryBuilder Self => this;

        public AppUninstallOperationQueryBuilder() : this("appUninstall")
        {
        }

        public AppUninstallOperationQueryBuilder(string name) : base(new Query<AppUninstallPayload>(name))
        {
        }

        public AppUninstallOperationQueryBuilder(IQuery<AppUninstallPayload> query) : base(query)
        {
        }

        public AppUninstallOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppUninstallOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUninstallAppUninstallErrorQueryBuilder> build)
        {
            var query = new Query<AppUninstallAppUninstallError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppUninstallAppUninstallErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppUninstallAppUninstallError>(query);
            return this;
        }
    }
}