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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class AbandonmentEmailStateUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<AbandonmentEmailStateUpdatePayload, AbandonmentEmailStateUpdatePayloadQueryBuilder>
    {
        protected override AbandonmentEmailStateUpdatePayloadQueryBuilder Self => this;

        public AbandonmentEmailStateUpdatePayloadQueryBuilder() : this("abandonmentEmailStateUpdatePayload")
        {
        }

        public AbandonmentEmailStateUpdatePayloadQueryBuilder(string name) : base(new Query<AbandonmentEmailStateUpdatePayload>(name))
        {
        }

        public AbandonmentEmailStateUpdatePayloadQueryBuilder(IQuery<AbandonmentEmailStateUpdatePayload> query) : base(query)
        {
        }

        public AbandonmentEmailStateUpdatePayloadQueryBuilder Abandonment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public AbandonmentEmailStateUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentEmailStateUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<AbandonmentEmailStateUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentEmailStateUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonmentEmailStateUpdateUserError>(query);
            return this;
        }
    }
}