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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ValidationConnectionQueryBuilder : FieldsQueryBuilderBase<ValidationConnection, ValidationConnectionQueryBuilder>
    {
        protected override ValidationConnectionQueryBuilder Self => this;

        public ValidationConnectionQueryBuilder() : this("validationConnection")
        {
        }

        public ValidationConnectionQueryBuilder(string name) : base(new Query<ValidationConnection>(name))
        {
        }

        public ValidationConnectionQueryBuilder(IQuery<ValidationConnection> query) : base(query)
        {
        }

        public ValidationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationEdgeQueryBuilder> build)
        {
            var query = new Query<ValidationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ValidationEdge>(query);
            return this;
        }

        public ValidationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }

        public ValidationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}