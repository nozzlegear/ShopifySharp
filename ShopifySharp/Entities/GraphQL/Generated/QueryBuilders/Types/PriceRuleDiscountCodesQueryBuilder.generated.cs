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
    public sealed class PriceRuleDiscountCodesQueryBuilder : FieldsQueryBuilderBase<PriceRuleDiscountCodeConnection, PriceRuleDiscountCodesQueryBuilder>, IHasArguments<PriceRuleDiscountCodesArgumentsBuilder>
    {
        public PriceRuleDiscountCodesArgumentsBuilder Arguments { get; }
        protected override PriceRuleDiscountCodesQueryBuilder Self => this;

        public PriceRuleDiscountCodesQueryBuilder(string name) : base(new Query<PriceRuleDiscountCodeConnection>(name))
        {
            Arguments = new PriceRuleDiscountCodesArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleDiscountCodesQueryBuilder(IQuery<PriceRuleDiscountCodeConnection> query) : base(query)
        {
            Arguments = new PriceRuleDiscountCodesArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleDiscountCodesQueryBuilder SetArguments(Action<PriceRuleDiscountCodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceRuleDiscountCodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeEdgeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCodeEdge>(query);
            return this;
        }

        public PriceRuleDiscountCodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceRuleDiscountCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCode>(query);
            return this;
        }

        public PriceRuleDiscountCodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}