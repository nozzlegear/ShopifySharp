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
    public sealed class MarketsB2BEntitlementQueryBuilder : FieldsQueryBuilderBase<MarketsB2BEntitlement, MarketsB2BEntitlementQueryBuilder>
    {
        protected override MarketsB2BEntitlementQueryBuilder Self => this;

        public MarketsB2BEntitlementQueryBuilder() : this("marketsB2BEntitlement")
        {
        }

        public MarketsB2BEntitlementQueryBuilder(string name) : base(new Query<MarketsB2BEntitlement>(name))
        {
        }

        public MarketsB2BEntitlementQueryBuilder(IQuery<MarketsB2BEntitlement> query) : base(query)
        {
        }

        public MarketsB2BEntitlementQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder> build)
        {
            var query = new Query<MarketsCatalogsEntitlement>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketsCatalogsEntitlementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketsCatalogsEntitlement>(query);
            return this;
        }

        public MarketsB2BEntitlementQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}