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
    public sealed class DraftOrderLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<DraftOrderLineItemConnection, DraftOrderLineItemConnectionQueryBuilder>
    {
        protected override DraftOrderLineItemConnectionQueryBuilder Self => this;

        public DraftOrderLineItemConnectionQueryBuilder() : this("draftOrderLineItemConnection")
        {
        }

        public DraftOrderLineItemConnectionQueryBuilder(string name) : base(new Query<DraftOrderLineItemConnection>(name))
        {
        }

        public DraftOrderLineItemConnectionQueryBuilder(IQuery<DraftOrderLineItemConnection> query) : base(query)
        {
        }

        public DraftOrderLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItemEdge>(query);
            return this;
        }

        public DraftOrderLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }

        public DraftOrderLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}