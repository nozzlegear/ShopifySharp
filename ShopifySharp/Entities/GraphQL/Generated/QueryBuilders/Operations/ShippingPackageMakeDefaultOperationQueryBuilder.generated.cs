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
    public sealed class ShippingPackageMakeDefaultOperationQueryBuilder : FieldsQueryBuilderBase<ShippingPackageMakeDefaultPayload, ShippingPackageMakeDefaultOperationQueryBuilder>, IGraphOperationQueryBuilder<ShippingPackageMakeDefaultPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShippingPackageMakeDefaultArgumentsBuilder Arguments { get; }
        protected override ShippingPackageMakeDefaultOperationQueryBuilder Self => this;

        public ShippingPackageMakeDefaultOperationQueryBuilder() : this("shippingPackageMakeDefault")
        {
        }

        public ShippingPackageMakeDefaultOperationQueryBuilder(string name) : base(new Query<ShippingPackageMakeDefaultPayload>(name))
        {
            Arguments = new ShippingPackageMakeDefaultArgumentsBuilder(base.InnerQuery);
        }

        public ShippingPackageMakeDefaultOperationQueryBuilder(IQuery<ShippingPackageMakeDefaultPayload> query) : base(query)
        {
            Arguments = new ShippingPackageMakeDefaultArgumentsBuilder(base.InnerQuery);
        }

        public ShippingPackageMakeDefaultOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}