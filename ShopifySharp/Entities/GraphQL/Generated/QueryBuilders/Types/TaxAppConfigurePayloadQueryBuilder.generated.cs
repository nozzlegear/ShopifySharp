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
    public sealed class TaxAppConfigurePayloadQueryBuilder : FieldsQueryBuilderBase<TaxAppConfigurePayload, TaxAppConfigurePayloadQueryBuilder>
    {
        protected override TaxAppConfigurePayloadQueryBuilder Self => this;

        public TaxAppConfigurePayloadQueryBuilder() : this("taxAppConfigurePayload")
        {
        }

        public TaxAppConfigurePayloadQueryBuilder(string name) : base(new Query<TaxAppConfigurePayload>(name))
        {
        }

        public TaxAppConfigurePayloadQueryBuilder(IQuery<TaxAppConfigurePayload> query) : base(query)
        {
        }

        public TaxAppConfigurePayloadQueryBuilder TaxAppConfiguration(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxAppConfigurationQueryBuilder> build)
        {
            var query = new Query<TaxAppConfiguration>("taxAppConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxAppConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxAppConfiguration>(query);
            return this;
        }

        public TaxAppConfigurePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxAppConfigureUserErrorQueryBuilder> build)
        {
            var query = new Query<TaxAppConfigureUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxAppConfigureUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxAppConfigureUserError>(query);
            return this;
        }
    }
}