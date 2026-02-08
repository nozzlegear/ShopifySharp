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
    public sealed class CheckoutBrandingColorSchemeQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingColorScheme, CheckoutBrandingColorSchemeQueryBuilder>
    {
        protected override CheckoutBrandingColorSchemeQueryBuilder Self => this;

        public CheckoutBrandingColorSchemeQueryBuilder() : this("checkoutBrandingColorScheme")
        {
        }

        public CheckoutBrandingColorSchemeQueryBuilder(string name) : base(new Query<CheckoutBrandingColorScheme>(name))
        {
        }

        public CheckoutBrandingColorSchemeQueryBuilder(IQuery<CheckoutBrandingColorScheme> query) : base(query)
        {
        }

        public CheckoutBrandingColorSchemeQueryBuilder Base(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorRoles>("base");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorRoles>(query);
            return this;
        }

        public CheckoutBrandingColorSchemeQueryBuilder Control(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingControlColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingControlColorRoles>("control");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingControlColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingControlColorRoles>(query);
            return this;
        }

        public CheckoutBrandingColorSchemeQueryBuilder PrimaryButton(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingButtonColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingButtonColorRoles>("primaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingButtonColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingButtonColorRoles>(query);
            return this;
        }

        public CheckoutBrandingColorSchemeQueryBuilder SecondaryButton(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingButtonColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingButtonColorRoles>("secondaryButton");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingButtonColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingButtonColorRoles>(query);
            return this;
        }
    }
}