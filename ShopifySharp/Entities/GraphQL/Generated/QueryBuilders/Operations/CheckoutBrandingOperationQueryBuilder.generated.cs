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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CheckoutBrandingOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutBranding, CheckoutBrandingOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutBranding>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CheckoutBrandingArgumentsBuilder Arguments { get; }
        protected override CheckoutBrandingOperationQueryBuilder Self => this;

        public CheckoutBrandingOperationQueryBuilder() : this("checkoutBranding")
        {
        }

        public CheckoutBrandingOperationQueryBuilder(string name) : base(new Query<CheckoutBranding>(name))
        {
            Arguments = new CheckoutBrandingArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingOperationQueryBuilder(IQuery<CheckoutBranding> query) : base(query)
        {
            Arguments = new CheckoutBrandingArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutBrandingOperationQueryBuilder Customizations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingCustomizationsQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingCustomizations>("customizations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingCustomizationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingCustomizations>(query);
            return this;
        }

        public CheckoutBrandingOperationQueryBuilder DesignSystem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingDesignSystemQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingDesignSystem>("designSystem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutBrandingDesignSystemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingDesignSystem>(query);
            return this;
        }
    }
}