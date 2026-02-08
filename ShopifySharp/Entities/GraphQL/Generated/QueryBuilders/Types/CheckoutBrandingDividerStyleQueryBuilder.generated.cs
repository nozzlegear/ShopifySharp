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
    public sealed class CheckoutBrandingDividerStyleQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingDividerStyle, CheckoutBrandingDividerStyleQueryBuilder>
    {
        protected override CheckoutBrandingDividerStyleQueryBuilder Self => this;

        public CheckoutBrandingDividerStyleQueryBuilder() : this("checkoutBrandingDividerStyle")
        {
        }

        public CheckoutBrandingDividerStyleQueryBuilder(string name) : base(new Query<CheckoutBrandingDividerStyle>(name))
        {
        }

        public CheckoutBrandingDividerStyleQueryBuilder(IQuery<CheckoutBrandingDividerStyle> query) : base(query)
        {
        }

        public CheckoutBrandingDividerStyleQueryBuilder BorderStyle()
        {
            base.InnerQuery.AddField("borderStyle");
            return this;
        }

        public CheckoutBrandingDividerStyleQueryBuilder BorderWidth()
        {
            base.InnerQuery.AddField("borderWidth");
            return this;
        }
    }
}