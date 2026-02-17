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
    public sealed class TaxAppConfigureOperationQueryBuilder : FieldsQueryBuilderBase<TaxAppConfigurePayload, TaxAppConfigureOperationQueryBuilder>, IGraphOperationQueryBuilder<TaxAppConfigurePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TaxAppConfigureArgumentsBuilder Arguments { get; }
        protected override TaxAppConfigureOperationQueryBuilder Self => this;

        public TaxAppConfigureOperationQueryBuilder() : this("taxAppConfigure")
        {
        }

        public TaxAppConfigureOperationQueryBuilder(string name) : base(new Query<TaxAppConfigurePayload>(name))
        {
            Arguments = new TaxAppConfigureArgumentsBuilder(base.InnerQuery);
        }

        public TaxAppConfigureOperationQueryBuilder(IQuery<TaxAppConfigurePayload> query) : base(query)
        {
            Arguments = new TaxAppConfigureArgumentsBuilder(base.InnerQuery);
        }

        public TaxAppConfigureOperationQueryBuilder TaxAppConfiguration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxAppConfigurationQueryBuilder> build)
        {
            var query = new Query<TaxAppConfiguration>("taxAppConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxAppConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxAppConfiguration>(query);
            return this;
        }

        public TaxAppConfigureOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxAppConfigureUserErrorQueryBuilder> build)
        {
            var query = new Query<TaxAppConfigureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxAppConfigureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxAppConfigureUserError>(query);
            return this;
        }
    }
}