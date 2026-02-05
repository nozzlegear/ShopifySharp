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
    public sealed class AppPricingDetailsQueryBuilder : FieldsQueryBuilderBase<AppPricingDetails, AppPricingDetailsQueryBuilder>
    {
        protected override AppPricingDetailsQueryBuilder Self => this;

        public AppPricingDetailsQueryBuilder() : this("appPricingDetails")
        {
        }

        public AppPricingDetailsQueryBuilder(string name) : base(new Query<AppPricingDetails>(name))
        {
        }

        public AppPricingDetailsQueryBuilder(IQuery<AppPricingDetails> query) : base(query)
        {
        }

        public AppPricingDetailsQueryBuilder AppPricingDetails(Action<AppPricingDetailsUnionCasesBuilder> build)
        {
            var query = new Query<AppPricingDetails>("appPricingDetails");
            var unionBuilder = new AppPricingDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}