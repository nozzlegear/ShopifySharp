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
    public sealed class CheckoutBrandingColorsQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingColors, CheckoutBrandingColorsQueryBuilder>
    {
        protected override CheckoutBrandingColorsQueryBuilder Self => this;

        public CheckoutBrandingColorsQueryBuilder() : this("checkoutBrandingColors")
        {
        }

        public CheckoutBrandingColorsQueryBuilder(string name) : base(new Query<CheckoutBrandingColors>(name))
        {
        }

        public CheckoutBrandingColorsQueryBuilder(IQuery<CheckoutBrandingColors> query) : base(query)
        {
        }

        public CheckoutBrandingColorsQueryBuilder Global(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorGlobalQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorGlobal>("global");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorGlobalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorGlobal>(query);
            return this;
        }

        public CheckoutBrandingColorsQueryBuilder Schemes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorSchemesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorSchemes>("schemes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorSchemesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorSchemes>(query);
            return this;
        }
    }
}