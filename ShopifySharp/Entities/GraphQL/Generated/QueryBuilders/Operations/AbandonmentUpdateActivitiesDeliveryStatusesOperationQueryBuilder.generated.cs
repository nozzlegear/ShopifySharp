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
    public sealed class AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder : FieldsQueryBuilderBase<AbandonmentUpdateActivitiesDeliveryStatusesPayload, AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder>, IGraphOperationQueryBuilder<AbandonmentUpdateActivitiesDeliveryStatusesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder Arguments { get; }
        protected override AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder Self => this;

        public AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder() : this("abandonmentUpdateActivitiesDeliveryStatuses")
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder(string name) : base(new Query<AbandonmentUpdateActivitiesDeliveryStatusesPayload>(name))
        {
            Arguments = new AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder(IQuery<AbandonmentUpdateActivitiesDeliveryStatusesPayload> query) : base(query)
        {
            Arguments = new AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder Abandonment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder> build)
        {
            var query = new Query<AbandonmentUpdateActivitiesDeliveryStatusesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonmentUpdateActivitiesDeliveryStatusesUserError>(query);
            return this;
        }
    }
}