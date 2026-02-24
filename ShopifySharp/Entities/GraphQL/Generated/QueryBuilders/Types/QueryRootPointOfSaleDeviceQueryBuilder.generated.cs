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

        public QueryRootPointOfSaleDeviceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}