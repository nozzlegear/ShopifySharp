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
    public sealed class ShippingPackageUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ShippingPackageUpdatePayload, ShippingPackageUpdatePayloadQueryBuilder>
    {
        protected override ShippingPackageUpdatePayloadQueryBuilder Self => this;

        public ShippingPackageUpdatePayloadQueryBuilder() : this("shippingPackageUpdatePayload")
        {
        }

        public ShippingPackageUpdatePayloadQueryBuilder(string name) : base(new Query<ShippingPackageUpdatePayload>(name))
        {
        }

        public ShippingPackageUpdatePayloadQueryBuilder(IQuery<ShippingPackageUpdatePayload> query) : base(query)
        {
        }

        public ShippingPackageUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}