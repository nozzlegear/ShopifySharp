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
    public sealed class PointOfSaleDeviceQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevice, PointOfSaleDeviceQueryBuilder>, IHasArguments<PointOfSaleDeviceArgumentsBuilder>
    {
        public PointOfSaleDeviceArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDeviceQueryBuilder Self => this;

        public PointOfSaleDeviceQueryBuilder() : this("pointOfSaleDevice")
        {
        }

        public PointOfSaleDeviceQueryBuilder(string name) : base(new Query<PointOfSaleDevice>(name))
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceQueryBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
            Arguments = new PointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceQueryBuilder SetArguments(Action<PointOfSaleDeviceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDeviceQueryBuilder ActivePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("activePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public PointOfSaleDeviceQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public PointOfSaleDeviceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}