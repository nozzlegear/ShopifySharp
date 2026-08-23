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
    public sealed class PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDeviceAssignToCashDrawerPayload, PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDeviceAssignToCashDrawerPayload>, IHasArguments<PointOfSaleDeviceAssignToCashDrawerArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PointOfSaleDeviceAssignToCashDrawerArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder Self => this;

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder() : this("pointOfSaleDeviceAssignToCashDrawer")
        {
        }

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder(string name) : base(new Query<PointOfSaleDeviceAssignToCashDrawerPayload>(name))
        {
            Arguments = new PointOfSaleDeviceAssignToCashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder(IQuery<PointOfSaleDeviceAssignToCashDrawerPayload> query) : base(query)
        {
            Arguments = new PointOfSaleDeviceAssignToCashDrawerArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder SetArguments(Action<PointOfSaleDeviceAssignToCashDrawerArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder PointOfSaleDevice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("pointOfSaleDevice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public PointOfSaleDeviceAssignToCashDrawerOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDeviceAssignToCashDrawerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDeviceAssignToCashDrawerUserError>(query);
            return this;
        }
    }
}