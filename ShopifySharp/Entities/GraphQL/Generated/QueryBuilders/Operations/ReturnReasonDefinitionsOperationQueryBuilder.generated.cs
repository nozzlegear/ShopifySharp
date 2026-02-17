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

        public ReturnReasonDefinitionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionEdge>(query);
            return this;
        }

        public ReturnReasonDefinitionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public ReturnReasonDefinitionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}