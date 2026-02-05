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
    public sealed class MarketsCatalogsEntitlementQueryBuilder : FieldsQueryBuilderBase<MarketsCatalogsEntitlement, MarketsCatalogsEntitlementQueryBuilder>
    {
        protected override MarketsCatalogsEntitlementQueryBuilder Self => this;

        public MarketsCatalogsEntitlementQueryBuilder() : this("marketsCatalogsEntitlement")
        {
        }

        public MarketsCatalogsEntitlementQueryBuilder(string name) : base(new Query<MarketsCatalogsEntitlement>(name))
        {
        }

        public MarketsCatalogsEntitlementQueryBuilder(IQuery<MarketsCatalogsEntitlement> query) : base(query)
        {
        }

        public MarketsCatalogsEntitlementQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}