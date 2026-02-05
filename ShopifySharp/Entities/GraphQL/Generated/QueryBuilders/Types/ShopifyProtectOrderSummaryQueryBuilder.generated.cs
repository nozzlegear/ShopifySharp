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
    public sealed class ShopifyProtectOrderSummaryQueryBuilder : FieldsQueryBuilderBase<ShopifyProtectOrderSummary, ShopifyProtectOrderSummaryQueryBuilder>
    {
        protected override ShopifyProtectOrderSummaryQueryBuilder Self => this;

        public ShopifyProtectOrderSummaryQueryBuilder() : this("shopifyProtectOrderSummary")
        {
        }

        public ShopifyProtectOrderSummaryQueryBuilder(string name) : base(new Query<ShopifyProtectOrderSummary>(name))
        {
        }

        public ShopifyProtectOrderSummaryQueryBuilder(IQuery<ShopifyProtectOrderSummary> query) : base(query)
        {
        }

        public ShopifyProtectOrderSummaryQueryBuilder Eligibility(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderEligibilityQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderEligibility>("eligibility");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyProtectOrderEligibilityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyProtectOrderEligibility>(query);
            return this;
        }

        public ShopifyProtectOrderSummaryQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}