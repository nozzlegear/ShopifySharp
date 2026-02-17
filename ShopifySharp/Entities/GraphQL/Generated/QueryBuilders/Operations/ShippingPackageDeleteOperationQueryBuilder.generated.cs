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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ShippingPackageDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ShippingPackageDeletePayload, ShippingPackageDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ShippingPackageDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShippingPackageDeleteArgumentsBuilder Arguments { get; }
        protected override ShippingPackageDeleteOperationQueryBuilder Self => this;

        public ShippingPackageDeleteOperationQueryBuilder() : this("shippingPackageDelete")
        {
        }

        public ShippingPackageDeleteOperationQueryBuilder(string name) : base(new Query<ShippingPackageDeletePayload>(name))
        {
            Arguments = new ShippingPackageDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ShippingPackageDeleteOperationQueryBuilder(IQuery<ShippingPackageDeletePayload> query) : base(query)
        {
            Arguments = new ShippingPackageDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ShippingPackageDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ShippingPackageDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}