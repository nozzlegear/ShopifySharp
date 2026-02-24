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
    public sealed class CheckoutBrandingQueryBuilder : FieldsQueryBuilderBase<CheckoutBranding, CheckoutBrandingQueryBuilder>, IHasArguments<CheckoutBrandingArgumentsBuilder>
    {
        public CheckoutBrandingArgumentsBuilder Arguments { get; }
        protected override CheckoutBrandingQueryBuilder Self => this;

        public CheckoutBrandingQueryBuilder() : this("checkoutBranding")
        {
        }

        public CheckoutBrandingQueryBuilder(string name) : base(new Query<CheckoutBranding>(name))
        {
            Arguments = new CheckoutBrandingArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingQueryBuilder(IQuery<CheckoutBranding> query) : base(query)
        {
            Arguments = new CheckoutBrandingArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingQueryBuilder SetArguments(Action<CheckoutBrandingArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutBrandingQueryBuilder Customizations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomizationsQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCustomizations>("customizations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingCustomizationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingCustomizations>(query);
            return this;
        }

        public CheckoutBrandingQueryBuilder DesignSystem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingDesignSystemQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingDesignSystem>("designSystem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingDesignSystemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingDesignSystem>(query);
            return this;
        }
    }
}