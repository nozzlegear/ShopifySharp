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
    public sealed class ShopifyPaymentsExtendedAuthorizationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsExtendedAuthorization, ShopifyPaymentsExtendedAuthorizationQueryBuilder>
    {
        protected override ShopifyPaymentsExtendedAuthorizationQueryBuilder Self => this;

        public ShopifyPaymentsExtendedAuthorizationQueryBuilder() : this("shopifyPaymentsExtendedAuthorization")
        {
        }

        public ShopifyPaymentsExtendedAuthorizationQueryBuilder(string name) : base(new Query<ShopifyPaymentsExtendedAuthorization>(name))
        {
        }

        public ShopifyPaymentsExtendedAuthorizationQueryBuilder(IQuery<ShopifyPaymentsExtendedAuthorization> query) : base(query)
        {
        }

        public ShopifyPaymentsExtendedAuthorizationQueryBuilder ExtendedAuthorizationExpiresAt()
        {
            base.InnerQuery.AddField("extendedAuthorizationExpiresAt");
            return this;
        }

        public ShopifyPaymentsExtendedAuthorizationQueryBuilder StandardAuthorizationExpiresAt()
        {
            base.InnerQuery.AddField("standardAuthorizationExpiresAt");
            return this;
        }
    }
}