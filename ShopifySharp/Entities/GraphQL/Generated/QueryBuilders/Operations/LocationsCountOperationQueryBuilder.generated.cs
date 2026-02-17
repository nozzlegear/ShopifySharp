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
    public sealed class LocationsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, LocationsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public LocationsCountArgumentsBuilder Arguments { get; }
        protected override LocationsCountOperationQueryBuilder Self => this;

        public LocationsCountOperationQueryBuilder() : this("locationsCount")
        {
        }

        public LocationsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new LocationsCountArgumentsBuilder(base.InnerQuery);
        }

        public LocationsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new LocationsCountArgumentsBuilder(base.InnerQuery);
        }

        public LocationsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public LocationsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}