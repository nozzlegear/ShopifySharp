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
    public sealed class DiscountRedeemCodeConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeConnection, DiscountRedeemCodeConnectionQueryBuilder>
    {
        protected override DiscountRedeemCodeConnectionQueryBuilder Self => this;

        public DiscountRedeemCodeConnectionQueryBuilder() : this("discountRedeemCodeConnection")
        {
        }

        public DiscountRedeemCodeConnectionQueryBuilder(string name) : base(new Query<DiscountRedeemCodeConnection>(name))
        {
        }

        public DiscountRedeemCodeConnectionQueryBuilder(IQuery<DiscountRedeemCodeConnection> query) : base(query)
        {
        }

        public DiscountRedeemCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeEdge>(query);
            return this;
        }

        public DiscountRedeemCodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCode>(query);
            return this;
        }

        public DiscountRedeemCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}