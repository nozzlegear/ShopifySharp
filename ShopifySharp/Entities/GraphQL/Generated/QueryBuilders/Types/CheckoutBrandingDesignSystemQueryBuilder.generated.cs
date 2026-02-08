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
    public sealed class CheckoutBrandingDesignSystemQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingDesignSystem, CheckoutBrandingDesignSystemQueryBuilder>
    {
        protected override CheckoutBrandingDesignSystemQueryBuilder Self => this;

        public CheckoutBrandingDesignSystemQueryBuilder() : this("checkoutBrandingDesignSystem")
        {
        }

        public CheckoutBrandingDesignSystemQueryBuilder(string name) : base(new Query<CheckoutBrandingDesignSystem>(name))
        {
        }

        public CheckoutBrandingDesignSystemQueryBuilder(IQuery<CheckoutBrandingDesignSystem> query) : base(query)
        {
        }

        public CheckoutBrandingDesignSystemQueryBuilder Colors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColors>(query);
            return this;
        }

        public CheckoutBrandingDesignSystemQueryBuilder CornerRadius(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingCornerRadiusVariablesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCornerRadiusVariables>("cornerRadius");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingCornerRadiusVariablesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingCornerRadiusVariables>(query);
            return this;
        }

        public CheckoutBrandingDesignSystemQueryBuilder Typography(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypography>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypography>(query);
            return this;
        }
    }
}