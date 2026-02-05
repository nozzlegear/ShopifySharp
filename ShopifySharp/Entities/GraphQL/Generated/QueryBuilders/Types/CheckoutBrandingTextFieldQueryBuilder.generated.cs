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
    public sealed class CheckoutBrandingTextFieldQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingTextField, CheckoutBrandingTextFieldQueryBuilder>
    {
        protected override CheckoutBrandingTextFieldQueryBuilder Self => this;

        public CheckoutBrandingTextFieldQueryBuilder() : this("checkoutBrandingTextField")
        {
        }

        public CheckoutBrandingTextFieldQueryBuilder(string name) : base(new Query<CheckoutBrandingTextField>(name))
        {
        }

        public CheckoutBrandingTextFieldQueryBuilder(IQuery<CheckoutBrandingTextField> query) : base(query)
        {
        }

        public CheckoutBrandingTextFieldQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingTextFieldQueryBuilder Typography(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyle>(query);
            return this;
        }
    }
}