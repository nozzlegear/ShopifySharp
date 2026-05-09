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
    public sealed class CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationBrandingTypographyStyle, CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder() : this("checkoutAndAccountsConfigurationBrandingTypographyStyle")
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationBrandingTypographyStyle>(name))
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder(IQuery<CheckoutAndAccountsConfigurationBrandingTypographyStyle> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder Font()
        {
            base.InnerQuery.AddField("font");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder Kerning()
        {
            base.InnerQuery.AddField("kerning");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder LetterCase()
        {
            base.InnerQuery.AddField("letterCase");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder Size()
        {
            base.InnerQuery.AddField("size");
            return this;
        }

        public CheckoutAndAccountsConfigurationBrandingTypographyStyleQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}