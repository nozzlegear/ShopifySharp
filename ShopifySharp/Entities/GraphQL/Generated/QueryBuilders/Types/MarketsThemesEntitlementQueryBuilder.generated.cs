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