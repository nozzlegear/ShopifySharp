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
    public sealed class MobilePlatformApplicationsOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationConnection, MobilePlatformApplicationsOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplicationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MobilePlatformApplicationsArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationsOperationQueryBuilder Self => this;

        public MobilePlatformApplicationsOperationQueryBuilder() : this("mobilePlatformApplications")
        {
        }

        public MobilePlatformApplicationsOperationQueryBuilder(string name) : base(new Query<MobilePlatformApplicationConnection>(name))
        {
            Arguments = new MobilePlatformApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationsOperationQueryBuilder(IQuery<MobilePlatformApplicationConnection> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationEdge>(query);
            return this;
        }

        public MobilePlatformApplicationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public MobilePlatformApplicationsOperationQueryBuilder Nodes(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("nodes");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}