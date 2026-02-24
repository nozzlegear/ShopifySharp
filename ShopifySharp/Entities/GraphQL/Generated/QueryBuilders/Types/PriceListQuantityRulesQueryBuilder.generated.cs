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
    public sealed class PriceListQuantityRulesQueryBuilder : FieldsQueryBuilderBase<QuantityRuleConnection, PriceListQuantityRulesQueryBuilder>, IHasArguments<PriceListQuantityRulesArgumentsBuilder>
    {
        public PriceListQuantityRulesArgumentsBuilder Arguments { get; }
        protected override PriceListQuantityRulesQueryBuilder Self => this;

        public PriceListQuantityRulesQueryBuilder(string name) : base(new Query<QuantityRuleConnection>(name))
        {
            Arguments = new PriceListQuantityRulesArgumentsBuilder(base.InnerQuery);
        }

        public PriceListQuantityRulesQueryBuilder(IQuery<QuantityRuleConnection> query) : base(query)
        {
            Arguments = new PriceListQuantityRulesArgumentsBuilder(base.InnerQuery);
        }

        public PriceListQuantityRulesQueryBuilder SetArguments(Action<PriceListQuantityRulesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceListQuantityRulesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleEdgeQueryBuilder> build)
        {
            var query = new Query<QuantityRuleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleEdge>(query);
            return this;
        }

        public PriceListQuantityRulesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder> build)
        {
            var query = new Query<QuantityRule>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRule>(query);
            return this;
        }

        public PriceListQuantityRulesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}