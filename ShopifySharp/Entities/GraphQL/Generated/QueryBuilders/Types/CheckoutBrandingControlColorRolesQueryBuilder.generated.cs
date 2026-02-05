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
    public sealed class CheckoutBrandingControlColorRolesQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingControlColorRoles, CheckoutBrandingControlColorRolesQueryBuilder>
    {
        protected override CheckoutBrandingControlColorRolesQueryBuilder Self => this;

        public CheckoutBrandingControlColorRolesQueryBuilder() : this("checkoutBrandingControlColorRoles")
        {
        }

        public CheckoutBrandingControlColorRolesQueryBuilder(string name) : base(new Query<CheckoutBrandingControlColorRoles>(name))
        {
        }

        public CheckoutBrandingControlColorRolesQueryBuilder(IQuery<CheckoutBrandingControlColorRoles> query) : base(query)
        {
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Accent()
        {
            base.InnerQuery.AddField("accent");
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Background()
        {
            base.InnerQuery.AddField("background");
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Border()
        {
            base.InnerQuery.AddField("border");
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Decorative()
        {
            base.InnerQuery.AddField("decorative");
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Icon()
        {
            base.InnerQuery.AddField("icon");
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Selected(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingColorRoles>("selected");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingColorRolesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingColorRoles>(query);
            return this;
        }

        public CheckoutBrandingControlColorRolesQueryBuilder Text()
        {
            base.InnerQuery.AddField("text");
            return this;
        }
    }
}