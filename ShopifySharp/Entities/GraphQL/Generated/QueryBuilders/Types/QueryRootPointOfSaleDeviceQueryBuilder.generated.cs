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
    public sealed class QueryRootPointOfSaleDeviceQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDevice, QueryRootPointOfSaleDeviceQueryBuilder>, IHasArguments<QueryRootPointOfSaleDeviceArgumentsBuilder>
    {
        public QueryRootPointOfSaleDeviceArgumentsBuilder Arguments { get; }
        protected override QueryRootPointOfSaleDeviceQueryBuilder Self => this;

        public QueryRootPointOfSaleDeviceQueryBuilder(string name) : base(new Query<PointOfSaleDevice>(name))
        {
            Arguments = new QueryRootPointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDeviceQueryBuilder(IQuery<PointOfSaleDevice> query) : base(query)
        {
            Arguments = new QueryRootPointOfSaleDeviceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPointOfSaleDeviceQueryBuilder SetArguments(Action<QueryRootPointOfSaleDeviceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPointOfSaleDeviceQueryBuilder ActivePaymentSession(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevicePaymentSession>("activePaymentSession");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDevicePaymentSessionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevicePaymentSession>(query);
            return this;
        }

        public QueryRootPointOfSaleDeviceQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public QueryRootPointOfSaleDeviceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}