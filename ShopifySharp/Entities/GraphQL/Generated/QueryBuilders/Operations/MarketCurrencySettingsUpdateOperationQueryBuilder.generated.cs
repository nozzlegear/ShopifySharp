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
    [Obsolete("This will be removed in a future version. Use `marketCreate` and `marketUpdate` for creating and updating market currency settings, respectively. ")]
    public sealed class MarketCurrencySettingsUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MarketCurrencySettingsUpdatePayload, MarketCurrencySettingsUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketCurrencySettingsUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketCurrencySettingsUpdateArgumentsBuilder Arguments { get; }
        protected override MarketCurrencySettingsUpdateOperationQueryBuilder Self => this;

        public MarketCurrencySettingsUpdateOperationQueryBuilder() : this("marketCurrencySettingsUpdate")
        {
        }

        public MarketCurrencySettingsUpdateOperationQueryBuilder(string name) : base(new Query<MarketCurrencySettingsUpdatePayload>(name))
        {
            Arguments = new MarketCurrencySettingsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketCurrencySettingsUpdateOperationQueryBuilder(IQuery<MarketCurrencySettingsUpdatePayload> query) : base(query)
        {
            Arguments = new MarketCurrencySettingsUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketCurrencySettingsUpdateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketCurrencySettingsUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCurrencySettingsUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketCurrencySettingsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCurrencySettingsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCurrencySettingsUserError>(query);
            return this;
        }
    }
}