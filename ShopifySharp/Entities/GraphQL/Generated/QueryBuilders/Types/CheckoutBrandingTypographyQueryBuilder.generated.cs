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
    public sealed class CheckoutBrandingTypographyQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingTypography, CheckoutBrandingTypographyQueryBuilder>
    {
        protected override CheckoutBrandingTypographyQueryBuilder Self => this;

        public CheckoutBrandingTypographyQueryBuilder() : this("checkoutBrandingTypography")
        {
        }

        public CheckoutBrandingTypographyQueryBuilder(string name) : base(new Query<CheckoutBrandingTypography>(name))
        {
        }

        public CheckoutBrandingTypographyQueryBuilder(IQuery<CheckoutBrandingTypography> query) : base(query)
        {
        }

        public CheckoutBrandingTypographyQueryBuilder Primary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingFontGroup>("primary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingFontGroup>(query);
            return this;
        }

        public CheckoutBrandingTypographyQueryBuilder Secondary(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontGroupQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingFontGroup>("secondary");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingFontGroup>(query);
            return this;
        }

        public CheckoutBrandingTypographyQueryBuilder Size(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontSizeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingFontSize>("size");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingFontSizeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingFontSize>(query);
            return this;
        }
    }
}