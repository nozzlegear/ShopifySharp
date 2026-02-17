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
    public sealed class CheckoutBrandingColorSchemesQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingColorSchemes, CheckoutBrandingColorSchemesQueryBuilder>
    {
        protected override CheckoutBrandingColorSchemesQueryBuilder Self => this;

        public CheckoutBrandingColorSchemesQueryBuilder() : this("checkoutBrandingColorSchemes")
        {
        }

        public CheckoutBrandingColorSchemesQueryBuilder(string name) : base(new Query<CheckoutBrandingColorSchemes>(name))
        {
        }

        public CheckoutBrandingColorSchemesQueryBuilder(IQuery<CheckoutBrandingColorSchemes> query) : base(query)
        {
        }

        public CheckoutBrandingColorSchemesQueryBuilder Scheme1(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorScheme>("scheme1");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorScheme>(query);
            return this;
        }

        public CheckoutBrandingColorSchemesQueryBuilder Scheme2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorScheme>("scheme2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorScheme>(query);
            return this;
        }

        public CheckoutBrandingColorSchemesQueryBuilder Scheme3(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorScheme>("scheme3");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorScheme>(query);
            return this;
        }

        public CheckoutBrandingColorSchemesQueryBuilder Scheme4(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorScheme>("scheme4");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingColorSchemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorScheme>(query);
            return this;
        }
    }
}