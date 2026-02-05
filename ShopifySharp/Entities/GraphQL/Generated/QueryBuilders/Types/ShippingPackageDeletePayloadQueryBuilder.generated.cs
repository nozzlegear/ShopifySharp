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
    public sealed class ShippingPackageDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ShippingPackageDeletePayload, ShippingPackageDeletePayloadQueryBuilder>
    {
        protected override ShippingPackageDeletePayloadQueryBuilder Self => this;

        public ShippingPackageDeletePayloadQueryBuilder() : this("shippingPackageDeletePayload")
        {
        }

        public ShippingPackageDeletePayloadQueryBuilder(string name) : base(new Query<ShippingPackageDeletePayload>(name))
        {
        }

        public ShippingPackageDeletePayloadQueryBuilder(IQuery<ShippingPackageDeletePayload> query) : base(query)
        {
        }

        public ShippingPackageDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ShippingPackageDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}