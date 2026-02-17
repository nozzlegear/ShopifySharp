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
    public sealed class CheckoutBrandingMainQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingMain, CheckoutBrandingMainQueryBuilder>
    {
        protected override CheckoutBrandingMainQueryBuilder Self => this;

        public CheckoutBrandingMainQueryBuilder() : this("checkoutBrandingMain")
        {
        }

        public CheckoutBrandingMainQueryBuilder(string name) : base(new Query<CheckoutBrandingMain>(name))
        {
        }

        public CheckoutBrandingMainQueryBuilder(IQuery<CheckoutBrandingMain> query) : base(query)
        {
        }

        public CheckoutBrandingMainQueryBuilder BackgroundImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingImage>("backgroundImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingImage>(query);
            return this;
        }

        public CheckoutBrandingMainQueryBuilder ColorScheme()
        {
            base.InnerQuery.AddField("colorScheme");
            return this;
        }

        public CheckoutBrandingMainQueryBuilder Divider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingContainerDivider>("divider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingContainerDividerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingContainerDivider>(query);
            return this;
        }

        public CheckoutBrandingMainQueryBuilder Section(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMainSectionQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingMainSection>("section");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingMainSectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingMainSection>(query);
            return this;
        }
    }
}