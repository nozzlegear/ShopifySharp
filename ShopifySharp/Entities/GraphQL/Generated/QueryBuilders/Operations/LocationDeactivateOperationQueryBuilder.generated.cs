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
    public sealed class LocationDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<LocationDeactivatePayload, LocationDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<LocationDeactivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public LocationDeactivateArgumentsBuilder Arguments { get; }
        protected override LocationDeactivateOperationQueryBuilder Self => this;

        public LocationDeactivateOperationQueryBuilder() : this("locationDeactivate")
        {
        }

        public LocationDeactivateOperationQueryBuilder(string name) : base(new Query<LocationDeactivatePayload>(name))
        {
            Arguments = new LocationDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public LocationDeactivateOperationQueryBuilder(IQuery<LocationDeactivatePayload> query) : base(query)
        {
            Arguments = new LocationDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public LocationDeactivateOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public LocationDeactivateOperationQueryBuilder LocationDeactivateUserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationDeactivateUserErrorQueryBuilder> build)
        {
            var query = new Query<LocationDeactivateUserError>("locationDeactivateUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationDeactivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationDeactivateUserError>(query);
            return this;
        }
    }
}