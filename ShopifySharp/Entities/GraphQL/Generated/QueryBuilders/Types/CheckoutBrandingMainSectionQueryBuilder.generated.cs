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
    public sealed class CheckoutBrandingMainSectionQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingMainSection, CheckoutBrandingMainSectionQueryBuilder>
    {
        protected override CheckoutBrandingMainSectionQueryBuilder Self => this;

        public CheckoutBrandingMainSectionQueryBuilder() : this("checkoutBrandingMainSection")
        {
        }

        public CheckoutBrandingMainSectionQueryBuilder(string name) : base(new Query<CheckoutBrandingMainSection>(name))
        {
        }

        public CheckoutBrandingMainSectionQueryBuilder(IQuery<CheckoutBrandingMainSection> query) : base(query)
        {
        }

        public CheckoutBrandingMainSectionQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutBrandingMainSectionQueryBuilder Shadow()
        {
            base.InnerQuery.AddField("shadow");
            return this;
        }
    }
}