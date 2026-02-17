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
    public sealed class CheckoutBrandingHeadingLevelQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingHeadingLevel, CheckoutBrandingHeadingLevelQueryBuilder>
    {
        protected override CheckoutBrandingHeadingLevelQueryBuilder Self => this;

        public CheckoutBrandingHeadingLevelQueryBuilder() : this("checkoutBrandingHeadingLevel")
        {
        }

        public CheckoutBrandingHeadingLevelQueryBuilder(string name) : base(new Query<CheckoutBrandingHeadingLevel>(name))
        {
        }

        public CheckoutBrandingHeadingLevelQueryBuilder(IQuery<CheckoutBrandingHeadingLevel> query) : base(query)
        {
        }

        public CheckoutBrandingHeadingLevelQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyle>(query);
            return this;
        }
    }
}