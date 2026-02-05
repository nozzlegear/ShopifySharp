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
    public sealed class ProductVendorsOperationQueryBuilder : FieldsQueryBuilderBase<StringConnection, ProductVendorsOperationQueryBuilder>, IGraphOperationQueryBuilder<StringConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductVendorsArgumentsBuilder Arguments { get; }
        protected override ProductVendorsOperationQueryBuilder Self => this;

        public ProductVendorsOperationQueryBuilder() : this("productVendors")
        {
        }

        public ProductVendorsOperationQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
            Arguments = new ProductVendorsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVendorsOperationQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
            Arguments = new ProductVendorsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVendorsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public ProductVendorsOperationQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public ProductVendorsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}