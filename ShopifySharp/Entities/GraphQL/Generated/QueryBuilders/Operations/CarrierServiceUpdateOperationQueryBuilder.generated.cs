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
    public sealed class CarrierServiceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CarrierServiceUpdatePayload, CarrierServiceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CarrierServiceUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CarrierServiceUpdateArgumentsBuilder Arguments { get; }
        protected override CarrierServiceUpdateOperationQueryBuilder Self => this;

        public CarrierServiceUpdateOperationQueryBuilder() : this("carrierServiceUpdate")
        {
        }

        public CarrierServiceUpdateOperationQueryBuilder(string name) : base(new Query<CarrierServiceUpdatePayload>(name))
        {
            Arguments = new CarrierServiceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceUpdateOperationQueryBuilder(IQuery<CarrierServiceUpdatePayload> query) : base(query)
        {
            Arguments = new CarrierServiceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CarrierServiceUpdateOperationQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public CarrierServiceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CarrierServiceUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CarrierServiceUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceUpdateUserError>(query);
            return this;
        }
    }
}