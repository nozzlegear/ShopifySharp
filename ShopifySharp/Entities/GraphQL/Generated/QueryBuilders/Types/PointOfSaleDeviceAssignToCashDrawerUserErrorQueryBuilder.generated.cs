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
    public sealed class PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDeviceAssignToCashDrawerUserError, PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder>
    {
        protected override PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder Self => this;

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder() : this("pointOfSaleDeviceAssignToCashDrawerUserError")
        {
        }

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder(string name) : base(new Query<PointOfSaleDeviceAssignToCashDrawerUserError>(name))
        {
        }

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder(IQuery<PointOfSaleDeviceAssignToCashDrawerUserError> query) : base(query)
        {
        }

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PointOfSaleDeviceAssignToCashDrawerUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}