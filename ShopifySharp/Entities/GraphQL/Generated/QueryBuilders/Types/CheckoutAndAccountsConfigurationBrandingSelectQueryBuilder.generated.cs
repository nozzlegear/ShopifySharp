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
    public sealed class CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingSelect, CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingSelect")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingSelect>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingSelect> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingSelectQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingTypographyStyle>(query);
            return this;
        }
    }
}