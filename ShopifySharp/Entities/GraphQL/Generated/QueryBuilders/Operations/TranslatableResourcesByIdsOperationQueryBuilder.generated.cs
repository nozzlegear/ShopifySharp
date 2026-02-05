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
    public sealed class TranslatableResourcesByIdsOperationQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceConnection, TranslatableResourcesByIdsOperationQueryBuilder>, IGraphOperationQueryBuilder<TranslatableResourceConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public TranslatableResourcesByIdsArgumentsBuilder Arguments { get; }
        protected override TranslatableResourcesByIdsOperationQueryBuilder Self => this;

        public TranslatableResourcesByIdsOperationQueryBuilder() : this("translatableResourcesByIds")
        {
        }

        public TranslatableResourcesByIdsOperationQueryBuilder(string name) : base(new Query<TranslatableResourceConnection>(name))
        {
            Arguments = new TranslatableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourcesByIdsOperationQueryBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
            Arguments = new TranslatableResourcesByIdsArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourcesByIdsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceEdge>(query);
            return this;
        }

        public TranslatableResourcesByIdsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }

        public TranslatableResourcesByIdsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}