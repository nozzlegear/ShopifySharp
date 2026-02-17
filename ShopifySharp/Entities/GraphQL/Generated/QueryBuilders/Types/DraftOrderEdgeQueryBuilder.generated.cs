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
    public sealed class DraftOrderEdgeQueryBuilder : FieldsQueryBuilderBase<DraftOrderEdge, DraftOrderEdgeQueryBuilder>
    {
        protected override DraftOrderEdgeQueryBuilder Self => this;

        public DraftOrderEdgeQueryBuilder() : this("draftOrderEdge")
        {
        }

        public DraftOrderEdgeQueryBuilder(string name) : base(new Query<DraftOrderEdge>(name))
        {
        }

        public DraftOrderEdgeQueryBuilder(IQuery<DraftOrderEdge> query) : base(query)
        {
        }

        public DraftOrderEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DraftOrderEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }
    }
}