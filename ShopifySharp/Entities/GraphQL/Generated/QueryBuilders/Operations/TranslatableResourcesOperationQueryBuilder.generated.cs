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
    public sealed class TranslatableResourcesOperationQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceConnection, TranslatableResourcesOperationQueryBuilder>, IGraphOperationQueryBuilder<TranslatableResourceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public TranslatableResourcesArgumentsBuilder Arguments { get; }
        protected override TranslatableResourcesOperationQueryBuilder Self => this;

        public TranslatableResourcesOperationQueryBuilder() : this("translatableResources")
        {
        }

        public TranslatableResourcesOperationQueryBuilder(string name) : base(new Query<TranslatableResourceConnection>(name))
        {
            Arguments = new TranslatableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourcesOperationQueryBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
            Arguments = new TranslatableResourcesArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourcesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceEdge>(query);
            return this;
        }

        public TranslatableResourcesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }

        public TranslatableResourcesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}