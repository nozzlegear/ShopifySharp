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
    public sealed class LocationEditOperationQueryBuilder : FieldsQueryBuilderBase<LocationEditPayload, LocationEditOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationEditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationEditArgumentsBuilder Arguments { get; }
        protected override LocationEditOperationQueryBuilder Self => this;

        public LocationEditOperationQueryBuilder() : this("locationEdit")
        {
        }

        public LocationEditOperationQueryBuilder(string name) : base(new Query<LocationEditPayload>(name))
        {
            Arguments = new LocationEditArgumentsBuilder(base.InnerQuery);
        }

        public LocationEditOperationQueryBuilder(IQuery<LocationEditPayload> query) : base(query)
        {
            Arguments = new LocationEditArgumentsBuilder(base.InnerQuery);
        }

        public LocationEditOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationEditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationEditUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationEditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationEditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationEditUserError>(query);
            return this;
        }
    }
}