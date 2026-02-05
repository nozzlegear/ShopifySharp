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
    public sealed class SellingPlanCheckoutChargeQueryBuilder : FieldsQueryBuilderBase<SellingPlanCheckoutCharge, SellingPlanCheckoutChargeQueryBuilder>
    {
        protected override SellingPlanCheckoutChargeQueryBuilder Self => this;

        public SellingPlanCheckoutChargeQueryBuilder() : this("sellingPlanCheckoutCharge")
        {
        }

        public SellingPlanCheckoutChargeQueryBuilder(string name) : base(new Query<SellingPlanCheckoutCharge>(name))
        {
        }

        public SellingPlanCheckoutChargeQueryBuilder(IQuery<SellingPlanCheckoutCharge> query) : base(query)
        {
        }

        public SellingPlanCheckoutChargeQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public SellingPlanCheckoutChargeQueryBuilder Value(Action<SellingPlanCheckoutChargeValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanCheckoutChargeValue>("value");
            var unionBuilder = new SellingPlanCheckoutChargeValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}