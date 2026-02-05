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
    public sealed class PointOfSaleDeviceOperationQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevice, PointOfSaleDeviceOperationQueryBuilder>, IGraphOperationQueryBuilder<PointOfSaleDevice>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PointOfSaleDeviceArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDeviceOperationQueryBuilder Self => this;

        public PointOfSaleDeviceOperationQueryBuilder() : this("pointOfSaleDevice")
        {
        }

        public PointOfSaleDeviceOperationQueryBuilder(string name) : base(new Query<PointOfSaleDevice>(name))
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceOperationQueryBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}