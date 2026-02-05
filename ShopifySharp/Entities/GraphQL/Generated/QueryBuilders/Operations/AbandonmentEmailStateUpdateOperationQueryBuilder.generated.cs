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
    [Obsolete("Use `abandonmentUpdateActivitiesDeliveryStatuses` instead.")]
    public sealed class AbandonmentEmailStateUpdateOperationQueryBuilder : FieldsQueryBuilderBase<AbandonmentEmailStateUpdatePayload, AbandonmentEmailStateUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<AbandonmentEmailStateUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AbandonmentEmailStateUpdateArgumentsBuilder Arguments { get; }
        protected override AbandonmentEmailStateUpdateOperationQueryBuilder Self => this;

        public AbandonmentEmailStateUpdateOperationQueryBuilder() : this("abandonmentEmailStateUpdate")
        {
        }

        public AbandonmentEmailStateUpdateOperationQueryBuilder(string name) : base(new Query<AbandonmentEmailStateUpdatePayload>(name))
        {
            Arguments = new AbandonmentEmailStateUpdateArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentEmailStateUpdateOperationQueryBuilder(IQuery<AbandonmentEmailStateUpdatePayload> query) : base(query)
        {
            Arguments = new AbandonmentEmailStateUpdateArgumentsBuilder(base.InnerQuery);
        }

        public AbandonmentEmailStateUpdateOperationQueryBuilder Abandonment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public AbandonmentEmailStateUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentEmailStateUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<AbandonmentEmailStateUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentEmailStateUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonmentEmailStateUpdateUserError>(query);
            return this;
        }
    }
}