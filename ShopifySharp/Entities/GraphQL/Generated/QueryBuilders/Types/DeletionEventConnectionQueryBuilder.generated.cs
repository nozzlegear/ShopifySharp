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
    public sealed class DeletionEventConnectionQueryBuilder : FieldsQueryBuilderBase<DeletionEventConnection, DeletionEventConnectionQueryBuilder>
    {
        protected override DeletionEventConnectionQueryBuilder Self => this;

        public DeletionEventConnectionQueryBuilder() : this("deletionEventConnection")
        {
        }

        public DeletionEventConnectionQueryBuilder(string name) : base(new Query<DeletionEventConnection>(name))
        {
        }

        public DeletionEventConnectionQueryBuilder(IQuery<DeletionEventConnection> query) : base(query)
        {
        }

        public DeletionEventConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventEdgeQueryBuilder> build)
        {
            var query = new Query<DeletionEventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEventEdge>(query);
            return this;
        }

        public DeletionEventConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder> build)
        {
            var query = new Query<DeletionEvent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeletionEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeletionEvent>(query);
            return this;
        }

        public DeletionEventConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}