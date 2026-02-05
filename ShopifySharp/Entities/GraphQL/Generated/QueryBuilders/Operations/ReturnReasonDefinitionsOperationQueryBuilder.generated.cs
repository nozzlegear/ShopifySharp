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
    public sealed class ReturnReasonDefinitionsOperationQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinitionConnection, ReturnReasonDefinitionsOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnReasonDefinitionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReturnReasonDefinitionsArgumentsBuilder Arguments { get; }
        protected override ReturnReasonDefinitionsOperationQueryBuilder Self => this;

        public ReturnReasonDefinitionsOperationQueryBuilder() : this("returnReasonDefinitions")
        {
        }

        public ReturnReasonDefinitionsOperationQueryBuilder(string name) : base(new Query<ReturnReasonDefinitionConnection>(name))
        {
            Arguments = new ReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReasonDefinitionsOperationQueryBuilder(IQuery<ReturnReasonDefinitionConnection> query) : base(query)
        {
            Arguments = new ReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReasonDefinitionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionEdge>(query);
            return this;
        }

        public ReturnReasonDefinitionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public ReturnReasonDefinitionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}