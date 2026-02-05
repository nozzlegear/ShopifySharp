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
    public sealed class MarketsRegionsEntitlementQueryBuilder : FieldsQueryBuilderBase<MarketsRegionsEntitlement, MarketsRegionsEntitlementQueryBuilder>
    {
        protected override MarketsRegionsEntitlementQueryBuilder Self => this;

        public MarketsRegionsEntitlementQueryBuilder() : this("marketsRegionsEntitlement")
        {
        }

        public MarketsRegionsEntitlementQueryBuilder(string name) : base(new Query<MarketsRegionsEntitlement>(name))
        {
        }

        public MarketsRegionsEntitlementQueryBuilder(IQuery<MarketsRegionsEntitlement> query) : base(query)
        {
        }

        public MarketsRegionsEntitlementQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsCatalogsEntitlement>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsCatalogsEntitlement>(query);
            return this;
        }

        public MarketsRegionsEntitlementQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}