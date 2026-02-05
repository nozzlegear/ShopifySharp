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
    public sealed class AppDiscountTypeEdgeQueryBuilder : FieldsQueryBuilderBase<AppDiscountTypeEdge, AppDiscountTypeEdgeQueryBuilder>
    {
        protected override AppDiscountTypeEdgeQueryBuilder Self => this;

        public AppDiscountTypeEdgeQueryBuilder() : this("appDiscountTypeEdge")
        {
        }

        public AppDiscountTypeEdgeQueryBuilder(string name) : base(new Query<AppDiscountTypeEdge>(name))
        {
        }

        public AppDiscountTypeEdgeQueryBuilder(IQuery<AppDiscountTypeEdge> query) : base(query)
        {
        }

        public AppDiscountTypeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppDiscountTypeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }
    }
}