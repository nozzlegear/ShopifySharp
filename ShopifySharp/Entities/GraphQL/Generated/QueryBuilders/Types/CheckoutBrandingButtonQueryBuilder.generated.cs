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
    public sealed class CheckoutBrandingButtonQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingButton, CheckoutBrandingButtonQueryBuilder>
    {
        protected override CheckoutBrandingButtonQueryBuilder Self => this;

        public CheckoutBrandingButtonQueryBuilder() : this("checkoutBrandingButton")
        {
        }

        public CheckoutBrandingButtonQueryBuilder(string name) : base(new Query<CheckoutBrandingButton>(name))
        {
        }

        public CheckoutBrandingButtonQueryBuilder(IQuery<CheckoutBrandingButton> query) : base(query)
        {
        }

        public CheckoutBrandingButtonQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingButtonQueryBuilder BlockPadding()
        {
            base.InnerQuery.AddField("blockPadding");
            return this;
        }

        public CheckoutBrandingButtonQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingButtonQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingButtonQueryBuilder InlinePadding()
        {
            base.InnerQuery.AddField("inlinePadding");
            return this;
        }

        public CheckoutBrandingButtonQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyle>(query);
            return this;
        }
    }
}