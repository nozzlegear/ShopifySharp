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