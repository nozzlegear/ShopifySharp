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
    public sealed class MarketsThemesEntitlementQueryBuilder : FieldsQueryBuilderBase<MarketsThemesEntitlement, MarketsThemesEntitlementQueryBuilder>
    {
        protected override MarketsThemesEntitlementQueryBuilder Self => this;

        public MarketsThemesEntitlementQueryBuilder() : this("marketsThemesEntitlement")
        {
        }

        public MarketsThemesEntitlementQueryBuilder(string name) : base(new Query<MarketsThemesEntitlement>(name))
        {
        }

        public MarketsThemesEntitlementQueryBuilder(IQuery<MarketsThemesEntitlement> query) : base(query)
        {
        }

        public MarketsThemesEntitlementQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }
    }
}