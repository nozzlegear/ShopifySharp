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

        public DraftOrderLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItemEdge>(query);
            return this;
        }

        public DraftOrderLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemQueryBuilder> build)
        {
            var query = new Query<DraftOrderLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderLineItem>(query);
            return this;
        }

        public DraftOrderLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}