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

        public CheckoutBrandingGlobalQueryBuilder Typography(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleGlobalQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingTypographyStyleGlobal>("typography");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingTypographyStyleGlobalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingTypographyStyleGlobal>(query);
            return this;
        }
    }
}