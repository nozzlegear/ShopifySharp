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
    public sealed class DomainQueryBuilder : FieldsQueryBuilderBase<Domain, DomainQueryBuilder>
    {
        protected override DomainQueryBuilder Self => this;

        public DomainQueryBuilder() : this("domain")
        {
        }

        public DomainQueryBuilder(string name) : base(new Query<Domain>(name))
        {
        }

        public DomainQueryBuilder(IQuery<Domain> query) : base(query)
        {
        }

        public DomainQueryBuilder Host()
        {
            base.InnerQuery.AddField("host");
            return this;
        }

        public DomainQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DomainQueryBuilder Localization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainLocalizationQueryBuilder> build)
        {
            var query = new Query<DomainLocalization>("localization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DomainLocalization>(query);
            return this;
        }

        public DomainQueryBuilder MarketWebPresence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public DomainQueryBuilder SslEnabled()
        {
            base.InnerQuery.AddField("sslEnabled");
            return this;
        }

        public DomainQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}