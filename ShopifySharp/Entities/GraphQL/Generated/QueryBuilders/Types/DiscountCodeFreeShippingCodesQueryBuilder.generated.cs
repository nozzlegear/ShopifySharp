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
    public sealed class DiscountCodeFreeShippingCodesQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeConnection, DiscountCodeFreeShippingCodesQueryBuilder>, IHasArguments<DiscountCodeFreeShippingCodesArgumentsBuilder>
    {
        public DiscountCodeFreeShippingCodesArgumentsBuilder Arguments { get; }
        protected override DiscountCodeFreeShippingCodesQueryBuilder Self => this;

        public DiscountCodeFreeShippingCodesQueryBuilder(string name) : base(new Query<DiscountRedeemCodeConnection>(name))
        {
            Arguments = new DiscountCodeFreeShippingCodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeFreeShippingCodesQueryBuilder(IQuery<DiscountRedeemCodeConnection> query) : base(query)
        {
            Arguments = new DiscountCodeFreeShippingCodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeFreeShippingCodesQueryBuilder SetArguments(Action<DiscountCodeFreeShippingCodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountCodeFreeShippingCodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeEdge>(query);
            return this;
        }

        public DiscountCodeFreeShippingCodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCode>(query);
            return this;
        }

        public DiscountCodeFreeShippingCodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}