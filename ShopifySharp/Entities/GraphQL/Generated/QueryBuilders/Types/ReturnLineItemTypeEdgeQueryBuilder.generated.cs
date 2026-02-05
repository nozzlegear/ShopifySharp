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

        public ReturnLineItemTypeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder> build)
        {
            var query = new Query<IReturnLineItemType>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IReturnLineItemType>(query);
            return this;
        }
    }
}