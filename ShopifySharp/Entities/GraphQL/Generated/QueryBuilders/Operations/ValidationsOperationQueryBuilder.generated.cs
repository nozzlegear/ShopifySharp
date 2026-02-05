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
    public sealed class ValidationsOperationQueryBuilder : FieldsQueryBuilderBase<ValidationConnection, ValidationsOperationQueryBuilder>, IGraphOperationQueryBuilder<ValidationConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ValidationsArgumentsBuilder Arguments { get; }
        protected override ValidationsOperationQueryBuilder Self => this;

        public ValidationsOperationQueryBuilder() : this("validations")
        {
        }

        public ValidationsOperationQueryBuilder(string name) : base(new Query<ValidationConnection>(name))
        {
            Arguments = new ValidationsArgumentsBuilder(base.InnerQuery);
        }

        public ValidationsOperationQueryBuilder(IQuery<ValidationConnection> query) : base(query)
        {
            Arguments = new ValidationsArgumentsBuilder(base.InnerQuery);
        }

        public ValidationsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationEdgeQueryBuilder> build)
        {
            var query = new Query<ValidationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationEdge>(query);
            return this;
        }

        public ValidationsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }

        public ValidationsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}