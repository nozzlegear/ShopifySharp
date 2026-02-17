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
    public sealed class MarketsRetailEntitlementQueryBuilder : FieldsQueryBuilderBase<MarketsRetailEntitlement, MarketsRetailEntitlementQueryBuilder>
    {
        protected override MarketsRetailEntitlementQueryBuilder Self => this;

        public MarketsRetailEntitlementQueryBuilder() : this("marketsRetailEntitlement")
        {
        }

        public MarketsRetailEntitlementQueryBuilder(string name) : base(new Query<MarketsRetailEntitlement>(name))
        {
        }

        public MarketsRetailEntitlementQueryBuilder(IQuery<MarketsRetailEntitlement> query) : base(query)
        {
        }

        public MarketsRetailEntitlementQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsCatalogsEntitlement>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsCatalogsEntitlement>(query);
            return this;
        }

        public MarketsRetailEntitlementQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}