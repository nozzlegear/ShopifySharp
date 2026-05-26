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
    public sealed class CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingButton, CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingButton")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingButton>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingButton> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder BlockPadding()
        {
            base.InnerQuery.AddField("blockPadding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder InlinePadding()
        {
            base.InnerQuery.AddField("inlinePadding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingButtonQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingTypographyStyle>(query);
            return this;
        }
    }
}