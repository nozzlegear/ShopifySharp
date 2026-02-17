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
    public sealed class CheckoutBrandingSelectQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingSelect, CheckoutBrandingSelectQueryBuilder>
    {
        protected override CheckoutBrandingSelectQueryBuilder Self => this;

        public CheckoutBrandingSelectQueryBuilder() : this("checkoutBrandingSelect")
        {
        }

        public CheckoutBrandingSelectQueryBuilder(string name) : base(new Query<CheckoutBrandingSelect>(name))
        {
        }

        public CheckoutBrandingSelectQueryBuilder(IQuery<CheckoutBrandingSelect> query) : base(query)
        {
        }

        public CheckoutBrandingSelectQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingSelectQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyle>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyle>(query);
            return this;
        }
    }
}