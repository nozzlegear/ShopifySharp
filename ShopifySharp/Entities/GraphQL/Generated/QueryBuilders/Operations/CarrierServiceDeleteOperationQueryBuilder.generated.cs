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
    public sealed class CarrierServiceDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CarrierServiceDeletePayload, CarrierServiceDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CarrierServiceDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CarrierServiceDeleteArgumentsBuilder Arguments { get; }
        protected override CarrierServiceDeleteOperationQueryBuilder Self => this;

        public CarrierServiceDeleteOperationQueryBuilder() : this("carrierServiceDelete")
        {
        }

        public CarrierServiceDeleteOperationQueryBuilder(string name) : base(new Query<CarrierServiceDeletePayload>(name))
        {
            Arguments = new CarrierServiceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceDeleteOperationQueryBuilder(IQuery<CarrierServiceDeletePayload> query) : base(query)
        {
            Arguments = new CarrierServiceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CarrierServiceDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceDeleteUserError>(query);
            return this;
        }
    }
}