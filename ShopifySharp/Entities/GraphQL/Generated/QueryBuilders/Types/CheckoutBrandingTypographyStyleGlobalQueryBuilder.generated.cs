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
    public sealed class CheckoutBrandingTypographyStyleGlobalQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingTypographyStyleGlobal, CheckoutBrandingTypographyStyleGlobalQueryBuilder>
    {
        protected override CheckoutBrandingTypographyStyleGlobalQueryBuilder Self => this;

        public CheckoutBrandingTypographyStyleGlobalQueryBuilder() : this("checkoutBrandingTypographyStyleGlobal")
        {
        }

        public CheckoutBrandingTypographyStyleGlobalQueryBuilder(string name) : base(new Query<CheckoutBrandingTypographyStyleGlobal>(name))
        {
        }

        public CheckoutBrandingTypographyStyleGlobalQueryBuilder(IQuery<CheckoutBrandingTypographyStyleGlobal> query) : base(query)
        {
        }

        public CheckoutBrandingTypographyStyleGlobalQueryBuilder Kerning()
        {
            base.InnerQuery.AddField("kerning");
            return this;
        }

        public CheckoutBrandingTypographyStyleGlobalQueryBuilder LetterCase()
        {
            base.InnerQuery.AddField("letterCase");
            return this;
        }
    }
}