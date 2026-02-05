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
    public sealed class ProductTagsOperationQueryBuilder : FieldsQueryBuilderBase<StringConnection, ProductTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<StringConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductTagsArgumentsBuilder Arguments { get; }
        protected override ProductTagsOperationQueryBuilder Self => this;

        public ProductTagsOperationQueryBuilder() : this("productTags")
        {
        }

        public ProductTagsOperationQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new ProductTagsArgumentsBuilder(base.InnerQuery);
        }

        public ProductTagsOperationQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new ProductTagsArgumentsBuilder(base.InnerQuery);
        }

        public ProductTagsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public ProductTagsOperationQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public ProductTagsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}