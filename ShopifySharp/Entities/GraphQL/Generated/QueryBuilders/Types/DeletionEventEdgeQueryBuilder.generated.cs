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
    public sealed class DeletionEventEdgeQueryBuilder : FieldsQueryBuilderBase<DeletionEventEdge, DeletionEventEdgeQueryBuilder>
    {
        protected override DeletionEventEdgeQueryBuilder Self => this;

        public DeletionEventEdgeQueryBuilder() : this("deletionEventEdge")
        {
        }

        public DeletionEventEdgeQueryBuilder(string name) : base(new Query<DeletionEventEdge>(name))
        {
        }

        public DeletionEventEdgeQueryBuilder(IQuery<DeletionEventEdge> query) : base(query)
        {
        }

        public DeletionEventEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeletionEventEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder> build)
        {
            var query = new Query<DeletionEvent>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEvent>(query);
            return this;
        }
    }
}