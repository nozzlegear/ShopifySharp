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
    public sealed class WebPresenceCreateOperationQueryBuilder : FieldsQueryBuilderBase<WebPresenceCreatePayload, WebPresenceCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPresenceCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPresenceCreateArgumentsBuilder Arguments { get; }
        protected override WebPresenceCreateOperationQueryBuilder Self => this;

        public WebPresenceCreateOperationQueryBuilder() : this("webPresenceCreate")
        {
        }

        public WebPresenceCreateOperationQueryBuilder(string name) : base(new Query<WebPresenceCreatePayload>(name))
        {
            Arguments = new WebPresenceCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceCreateOperationQueryBuilder(IQuery<WebPresenceCreatePayload> query) : base(query)
        {
            Arguments = new WebPresenceCreateArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }

        public WebPresenceCreateOperationQueryBuilder WebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("webPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }
    }
}