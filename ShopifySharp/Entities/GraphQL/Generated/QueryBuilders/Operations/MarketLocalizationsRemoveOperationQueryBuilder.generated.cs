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
    public sealed class MarketLocalizationsRemoveOperationQueryBuilder : FieldsQueryBuilderBase<MarketLocalizationsRemovePayload, MarketLocalizationsRemoveOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketLocalizationsRemovePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketLocalizationsRemoveArgumentsBuilder Arguments { get; }
        protected override MarketLocalizationsRemoveOperationQueryBuilder Self => this;

        public MarketLocalizationsRemoveOperationQueryBuilder() : this("marketLocalizationsRemove")
        {
        }

        public MarketLocalizationsRemoveOperationQueryBuilder(string name) : base(new Query<MarketLocalizationsRemovePayload>(name))
        {
            Arguments = new MarketLocalizationsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizationsRemoveOperationQueryBuilder(IQuery<MarketLocalizationsRemovePayload> query) : base(query)
        {
            Arguments = new MarketLocalizationsRemoveArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizationsRemoveOperationQueryBuilder MarketLocalizations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizationQueryBuilder> build)
        {
            var query = new Query<MarketLocalization>("marketLocalizations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalization>(query);
            return this;
        }

        public MarketLocalizationsRemoveOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder> build)
        {
            var query = new Query<TranslationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslationUserError>(query);
            return this;
        }
    }
}