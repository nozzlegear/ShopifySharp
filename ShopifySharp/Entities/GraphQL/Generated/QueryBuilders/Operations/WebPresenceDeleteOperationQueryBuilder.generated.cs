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
    public sealed class WebPresenceDeleteOperationQueryBuilder : FieldsQueryBuilderBase<WebPresenceDeletePayload, WebPresenceDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPresenceDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPresenceDeleteArgumentsBuilder Arguments { get; }
        protected override WebPresenceDeleteOperationQueryBuilder Self => this;

        public WebPresenceDeleteOperationQueryBuilder() : this("webPresenceDelete")
        {
        }

        public WebPresenceDeleteOperationQueryBuilder(string name) : base(new Query<WebPresenceDeletePayload>(name))
        {
            Arguments = new WebPresenceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceDeleteOperationQueryBuilder(IQuery<WebPresenceDeletePayload> query) : base(query)
        {
            Arguments = new WebPresenceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public WebPresenceDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}