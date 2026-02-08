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
    public sealed class PointOfSaleDeviceQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevice, PointOfSaleDeviceQueryBuilder>
    {
        protected override PointOfSaleDeviceQueryBuilder Self => this;

        public PointOfSaleDeviceQueryBuilder() : this("pointOfSaleDevice")
        {
        }

        public PointOfSaleDeviceQueryBuilder(string name) : base(new Query<PointOfSaleDevice>(name))
        {
        }

        public PointOfSaleDeviceQueryBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
        }

        public PointOfSaleDeviceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}