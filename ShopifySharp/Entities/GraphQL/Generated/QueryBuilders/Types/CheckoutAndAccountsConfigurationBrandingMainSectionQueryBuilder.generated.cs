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
    public sealed class CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingMainSection, CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingMainSection")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingMainSection>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingMainSection> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Colors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationBrandingColors>("colors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationBrandingColorsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationBrandingColors>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingMainSectionQueryBuilder Shadow()
        {
            base.InnerQuery.AddField("shadow");
            return this;
        }
    }
}