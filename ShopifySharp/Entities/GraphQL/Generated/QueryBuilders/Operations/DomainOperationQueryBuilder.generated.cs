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
    public sealed class DomainOperationQueryBuilder : FieldsQueryBuilderBase<Domain, DomainOperationQueryBuilder>, IGraphOperationQueryBuilder<Domain>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DomainArgumentsBuilder Arguments { get; }
        protected override DomainOperationQueryBuilder Self => this;

        public DomainOperationQueryBuilder() : this("domain")
        {
        }

        public DomainOperationQueryBuilder(string name) : base(new Query<Domain>(name))
        {
            Arguments = new DomainArgumentsBuilder(base.InnerQuery);
        }

        public DomainOperationQueryBuilder(IQuery<Domain> query) : base(query)
        {
            Arguments = new DomainArgumentsBuilder(base.InnerQuery);
        }

        public DomainOperationQueryBuilder Host()
        {
            base.InnerQuery.AddField("host");
            return this;
        }

        public DomainOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DomainOperationQueryBuilder Localization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainLocalizationQueryBuilder> build)
        {
            var query = new Query<DomainLocalization>("localization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DomainLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DomainLocalization>(query);
            return this;
        }

        public DomainOperationQueryBuilder MarketWebPresence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public DomainOperationQueryBuilder SslEnabled()
        {
            base.InnerQuery.AddField("sslEnabled");
            return this;
        }

        public DomainOperationQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}