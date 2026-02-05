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
    public sealed class ReturnLineItemTypeConnectionQueryBuilder : FieldsQueryBuilderBase<ReturnLineItemTypeConnection, ReturnLineItemTypeConnectionQueryBuilder>
    {
        protected override ReturnLineItemTypeConnectionQueryBuilder Self => this;

        public ReturnLineItemTypeConnectionQueryBuilder() : this("returnLineItemTypeConnection")
        {
        }

        public ReturnLineItemTypeConnectionQueryBuilder(string name) : base(new Query<ReturnLineItemTypeConnection>(name))
        {
        }

        public ReturnLineItemTypeConnectionQueryBuilder(IQuery<ReturnLineItemTypeConnection> query) : base(query)
        {
        }

        public ReturnLineItemTypeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnLineItemTypeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnLineItemTypeEdge>(query);
            return this;
        }

        public ReturnLineItemTypeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder> build)
        {
            var query = new Query<IReturnLineItemType>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IReturnLineItemType>(query);
            return this;
        }

        public ReturnLineItemTypeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}