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
    public sealed class DeliverySettingUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DeliverySettingUpdatePayload, DeliverySettingUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliverySettingUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliverySettingUpdateArgumentsBuilder Arguments { get; }
        protected override DeliverySettingUpdateOperationQueryBuilder Self => this;

        public DeliverySettingUpdateOperationQueryBuilder() : this("deliverySettingUpdate")
        {
        }

        public DeliverySettingUpdateOperationQueryBuilder(string name) : base(new Query<DeliverySettingUpdatePayload>(name))
        {
            Arguments = new DeliverySettingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliverySettingUpdateOperationQueryBuilder(IQuery<DeliverySettingUpdatePayload> query) : base(query)
        {
            Arguments = new DeliverySettingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DeliverySettingUpdateOperationQueryBuilder Setting(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliverySettingQueryBuilder> build)
        {
            var query = new Query<DeliverySetting>("setting");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliverySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliverySetting>(query);
            return this;
        }

        public DeliverySettingUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}