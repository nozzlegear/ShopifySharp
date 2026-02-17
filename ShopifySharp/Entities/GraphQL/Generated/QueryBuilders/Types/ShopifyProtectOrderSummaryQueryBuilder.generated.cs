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

        public ShopifyProtectOrderSummaryQueryBuilder Eligibility(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyProtectOrderEligibilityQueryBuilder> build)
        {
            var query = new Query<ShopifyProtectOrderEligibility>("eligibility");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyProtectOrderEligibilityQueryBuilder(query);
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