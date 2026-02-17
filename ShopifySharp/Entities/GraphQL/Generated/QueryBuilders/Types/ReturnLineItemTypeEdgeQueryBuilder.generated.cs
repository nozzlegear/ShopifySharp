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
    public sealed class ReturnLineItemTypeEdgeQueryBuilder : FieldsQueryBuilderBase<ReturnLineItemTypeEdge, ReturnLineItemTypeEdgeQueryBuilder>
    {
        protected override ReturnLineItemTypeEdgeQueryBuilder Self => this;

        public ReturnLineItemTypeEdgeQueryBuilder() : this("returnLineItemTypeEdge")
        {
        }

        public ReturnLineItemTypeEdgeQueryBuilder(string name) : base(new Query<ReturnLineItemTypeEdge>(name))
        {
        }

        public ReturnLineItemTypeEdgeQueryBuilder(IQuery<ReturnLineItemTypeEdge> query) : base(query)
        {
        }

        public ReturnLineItemTypeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReturnLineItemTypeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder> build)
        {
            var query = new Query<IReturnLineItemType>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IReturnLineItemType>(query);
            return this;
        }
    }
}