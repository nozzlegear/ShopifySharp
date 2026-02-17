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
    public sealed class MarketLocalizationsRegisterOperationQueryBuilder : FieldsQueryBuilderBase<MarketLocalizationsRegisterPayload, MarketLocalizationsRegisterOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketLocalizationsRegisterPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketLocalizationsRegisterArgumentsBuilder Arguments { get; }
        protected override MarketLocalizationsRegisterOperationQueryBuilder Self => this;

        public MarketLocalizationsRegisterOperationQueryBuilder() : this("marketLocalizationsRegister")
        {
        }

        public MarketLocalizationsRegisterOperationQueryBuilder(string name) : base(new Query<MarketLocalizationsRegisterPayload>(name))
        {
            Arguments = new MarketLocalizationsRegisterArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizationsRegisterOperationQueryBuilder(IQuery<MarketLocalizationsRegisterPayload> query) : base(query)
        {
            Arguments = new MarketLocalizationsRegisterArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizationsRegisterOperationQueryBuilder MarketLocalizations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder> build)
        {
            var query = new Query<MarketLocalization>("marketLocalizations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalization>(query);
            return this;
        }

        public MarketLocalizationsRegisterOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationUserErrorQueryBuilder> build)
        {
            var query = new Query<TranslationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslationUserError>(query);
            return this;
        }
    }
}