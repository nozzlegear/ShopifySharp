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
    public sealed class MarketsTypeQueryBuilder : FieldsQueryBuilderBase<MarketsType, MarketsTypeQueryBuilder>
    {
        protected override MarketsTypeQueryBuilder Self => this;

        public MarketsTypeQueryBuilder() : this("marketsType")
        {
        }

        public MarketsTypeQueryBuilder(string name) : base(new Query<MarketsType>(name))
        {
        }

        public MarketsTypeQueryBuilder(IQuery<MarketsType> query) : base(query)
        {
        }

        public MarketsTypeQueryBuilder B2b(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsB2BEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsB2BEntitlement>("b2b");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsB2BEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsB2BEntitlement>(query);
            return this;
        }

        public MarketsTypeQueryBuilder Regions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsRegionsEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsRegionsEntitlement>("regions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsRegionsEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsRegionsEntitlement>(query);
            return this;
        }

        public MarketsTypeQueryBuilder Retail(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsRetailEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsRetailEntitlement>("retail");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsRetailEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsRetailEntitlement>(query);
            return this;
        }

        public MarketsTypeQueryBuilder Themes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsThemesEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsThemesEntitlement>("themes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsThemesEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsThemesEntitlement>(query);
            return this;
        }
    }
}