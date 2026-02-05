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
    public sealed class CheckoutBrandingHeaderQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingHeader, CheckoutBrandingHeaderQueryBuilder>
    {
        protected override CheckoutBrandingHeaderQueryBuilder Self => this;

        public CheckoutBrandingHeaderQueryBuilder() : this("checkoutBrandingHeader")
        {
        }

        public CheckoutBrandingHeaderQueryBuilder(string name) : base(new Query<CheckoutBrandingHeader>(name))
        {
        }

        public CheckoutBrandingHeaderQueryBuilder(IQuery<CheckoutBrandingHeader> query) : base(query)
        {
        }

        public CheckoutBrandingHeaderQueryBuilder Alignment()
        {
            base.InnerQuery.AddField("alignment");
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder Banner(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingImage>("banner");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingImage>(query);
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder CartLink(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingHeaderCartLinkQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingHeaderCartLink>("cartLink");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingHeaderCartLinkQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingHeaderCartLink>(query);
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder Divided()
        {
            base.InnerQuery.AddField("divided");
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder Logo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingLogoQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingLogo>("logo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingLogoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingLogo>(query);
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder Padding()
        {
            base.InnerQuery.AddField("padding");
            return this;
        }

        public CheckoutBrandingHeaderQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }
    }
}