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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootDomainQueryBuilder : FieldsQueryBuilderBase<Domain, QueryRootDomainQueryBuilder>, IHasArguments<QueryRootDomainArgumentsBuilder>
    {
        public QueryRootDomainArgumentsBuilder Arguments { get; }
        protected override QueryRootDomainQueryBuilder Self => this;

        public QueryRootDomainQueryBuilder(string name) : base(new Query<Domain>(name))
        {
            Arguments = new QueryRootDomainArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDomainQueryBuilder(IQuery<Domain> query) : base(query)
        {
            Arguments = new QueryRootDomainArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDomainQueryBuilder SetArguments(Action<QueryRootDomainArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDomainQueryBuilder Host()
        {
            base.InnerQuery.AddField("host");
            return this;
        }

        public QueryRootDomainQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDomainQueryBuilder Localization(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DomainLocalizationQueryBuilder> build)
        {
            var query = new Query<DomainLocalization>("localization");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DomainLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DomainLocalization>(query);
            return this;
        }

        public QueryRootDomainQueryBuilder MarketWebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public QueryRootDomainQueryBuilder SslEnabled()
        {
            base.InnerQuery.AddField("sslEnabled");
            return this;
        }

        public QueryRootDomainQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}