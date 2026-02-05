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
    public sealed class CheckoutBrandingTypographyStyleQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingTypographyStyle, CheckoutBrandingTypographyStyleQueryBuilder>
    {
        protected override CheckoutBrandingTypographyStyleQueryBuilder Self => this;

        public CheckoutBrandingTypographyStyleQueryBuilder() : this("checkoutBrandingTypographyStyle")
        {
        }

        public CheckoutBrandingTypographyStyleQueryBuilder(string name) : base(new Query<CheckoutBrandingTypographyStyle>(name))
        {
        }

        public CheckoutBrandingTypographyStyleQueryBuilder(IQuery<CheckoutBrandingTypographyStyle> query) : base(query)
        {
        }

        public CheckoutBrandingTypographyStyleQueryBuilder Font()
        {
            base.InnerQuery.AddField("font");
            return this;
        }

        public CheckoutBrandingTypographyStyleQueryBuilder Kerning()
        {
            base.InnerQuery.AddField("kerning");
            return this;
        }

        public CheckoutBrandingTypographyStyleQueryBuilder LetterCase()
        {
            base.InnerQuery.AddField("letterCase");
            return this;
        }

        public CheckoutBrandingTypographyStyleQueryBuilder Size()
        {
            base.InnerQuery.AddField("size");
            return this;
        }

        public CheckoutBrandingTypographyStyleQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}