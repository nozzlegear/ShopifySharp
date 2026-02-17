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
    public sealed class CarrierServiceCreateOperationQueryBuilder : FieldsQueryBuilderBase<CarrierServiceCreatePayload, CarrierServiceCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CarrierServiceCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CarrierServiceCreateArgumentsBuilder Arguments { get; }
        protected override CarrierServiceCreateOperationQueryBuilder Self => this;

        public CarrierServiceCreateOperationQueryBuilder() : this("carrierServiceCreate")
        {
        }

        public CarrierServiceCreateOperationQueryBuilder(string name) : base(new Query<CarrierServiceCreatePayload>(name))
        {
            Arguments = new CarrierServiceCreateArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceCreateOperationQueryBuilder(IQuery<CarrierServiceCreatePayload> query) : base(query)
        {
            Arguments = new CarrierServiceCreateArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceCreateOperationQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public CarrierServiceCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CarrierServiceCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CarrierServiceCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceCreateUserError>(query);
            return this;
        }
    }
}