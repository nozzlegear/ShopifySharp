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
    public sealed class LocalizedFieldEdgeQueryBuilder : FieldsQueryBuilderBase<LocalizedFieldEdge, LocalizedFieldEdgeQueryBuilder>
    {
        protected override LocalizedFieldEdgeQueryBuilder Self => this;

        public LocalizedFieldEdgeQueryBuilder() : this("localizedFieldEdge")
        {
        }

        public LocalizedFieldEdgeQueryBuilder(string name) : base(new Query<LocalizedFieldEdge>(name))
        {
        }

        public LocalizedFieldEdgeQueryBuilder(IQuery<LocalizedFieldEdge> query) : base(query)
        {
        }

        public LocalizedFieldEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public LocalizedFieldEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder> build)
        {
            var query = new Query<LocalizedField>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedField>(query);
            return this;
        }
    }
}