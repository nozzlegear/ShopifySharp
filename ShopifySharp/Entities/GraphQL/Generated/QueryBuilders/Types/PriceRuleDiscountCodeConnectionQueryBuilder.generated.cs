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
    public sealed class PriceRuleDiscountCodeConnectionQueryBuilder : FieldsQueryBuilderBase<PriceRuleDiscountCodeConnection, PriceRuleDiscountCodeConnectionQueryBuilder>
    {
        protected override PriceRuleDiscountCodeConnectionQueryBuilder Self => this;

        public PriceRuleDiscountCodeConnectionQueryBuilder() : this("priceRuleDiscountCodeConnection")
        {
        }

        public PriceRuleDiscountCodeConnectionQueryBuilder(string name) : base(new Query<PriceRuleDiscountCodeConnection>(name))
        {
        }

        public PriceRuleDiscountCodeConnectionQueryBuilder(IQuery<PriceRuleDiscountCodeConnection> query) : base(query)
        {
        }

        public PriceRuleDiscountCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeEdgeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCodeEdge>(query);
            return this;
        }

        public PriceRuleDiscountCodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCode>(query);
            return this;
        }

        public PriceRuleDiscountCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}