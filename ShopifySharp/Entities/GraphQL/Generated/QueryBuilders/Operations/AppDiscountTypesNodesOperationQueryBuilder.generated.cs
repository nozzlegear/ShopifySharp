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
    public sealed class AppDiscountTypesNodesOperationQueryBuilder : FieldsQueryBuilderBase<AppDiscountTypeConnection, AppDiscountTypesNodesOperationQueryBuilder>, IGraphOperationQueryBuilder<AppDiscountTypeConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppDiscountTypesNodesArgumentsBuilder Arguments { get; }
        protected override AppDiscountTypesNodesOperationQueryBuilder Self => this;

        public AppDiscountTypesNodesOperationQueryBuilder() : this("appDiscountTypesNodes")
        {
        }

        public AppDiscountTypesNodesOperationQueryBuilder(string name) : base(new Query<AppDiscountTypeConnection>(name))
        {
            Arguments = new AppDiscountTypesNodesArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypesNodesOperationQueryBuilder(IQuery<AppDiscountTypeConnection> query) : base(query)
        {
            Arguments = new AppDiscountTypesNodesArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypesNodesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeEdgeQueryBuilder> build)
        {
            var query = new Query<AppDiscountTypeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountTypeEdge>(query);
            return this;
        }

        public AppDiscountTypesNodesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public AppDiscountTypesNodesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}