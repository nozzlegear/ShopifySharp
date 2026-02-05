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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ValidationEdgeQueryBuilder : FieldsQueryBuilderBase<ValidationEdge, ValidationEdgeQueryBuilder>
    {
        protected override ValidationEdgeQueryBuilder Self => this;

        public ValidationEdgeQueryBuilder() : this("validationEdge")
        {
        }

        public ValidationEdgeQueryBuilder(string name) : base(new Query<ValidationEdge>(name))
        {
        }

        public ValidationEdgeQueryBuilder(IQuery<ValidationEdge> query) : base(query)
        {
        }

        public ValidationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ValidationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder> build)
        {
            var query = new Query<Validation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Validation>(query);
            return this;
        }
    }
}