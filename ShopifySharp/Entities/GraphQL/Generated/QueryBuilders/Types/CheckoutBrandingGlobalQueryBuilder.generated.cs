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
    public sealed class CheckoutBrandingGlobalQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingGlobal, CheckoutBrandingGlobalQueryBuilder>
    {
        protected override CheckoutBrandingGlobalQueryBuilder Self => this;

        public CheckoutBrandingGlobalQueryBuilder() : this("checkoutBrandingGlobal")
        {
        }

        public CheckoutBrandingGlobalQueryBuilder(string name) : base(new Query<CheckoutBrandingGlobal>(name))
        {
        }

        public CheckoutBrandingGlobalQueryBuilder(IQuery<CheckoutBrandingGlobal> query) : base(query)
        {
        }

        public CheckoutBrandingGlobalQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }

        public CheckoutBrandingGlobalQueryBuilder Typography(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyStyleGlobalQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyleGlobal>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingTypographyStyleGlobalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyleGlobal>(query);
            return this;
        }
    }
}