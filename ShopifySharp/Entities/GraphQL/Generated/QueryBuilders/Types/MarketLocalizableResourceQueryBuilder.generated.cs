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
    public sealed class MarketLocalizableResourceQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResource, MarketLocalizableResourceQueryBuilder>
    {
        protected override MarketLocalizableResourceQueryBuilder Self => this;

        public MarketLocalizableResourceQueryBuilder() : this("marketLocalizableResource")
        {
        }

        public MarketLocalizableResourceQueryBuilder(string name) : base(new Query<MarketLocalizableResource>(name))
        {
        }

        public MarketLocalizableResourceQueryBuilder(IQuery<MarketLocalizableResource> query) : base(query)
        {
        }

        public MarketLocalizableResourceQueryBuilder MarketLocalizableContent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableContentQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableContent>("marketLocalizableContent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableContent>(query);
            return this;
        }

        public MarketLocalizableResourceQueryBuilder MarketLocalizations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizationQueryBuilder> build)
        {
            var query = new Query<MarketLocalization>("marketLocalizations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalization>(query);
            return this;
        }

        public MarketLocalizableResourceQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }
    }
}