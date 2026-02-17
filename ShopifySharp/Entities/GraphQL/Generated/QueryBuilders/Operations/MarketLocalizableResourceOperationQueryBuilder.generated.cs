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
    public sealed class MarketLocalizableResourceOperationQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResource, MarketLocalizableResourceOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketLocalizableResource>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketLocalizableResourceArgumentsBuilder Arguments { get; }
        protected override MarketLocalizableResourceOperationQueryBuilder Self => this;

        public MarketLocalizableResourceOperationQueryBuilder() : this("marketLocalizableResource")
        {
        }

        public MarketLocalizableResourceOperationQueryBuilder(string name) : base(new Query<MarketLocalizableResource>(name))
        {
            Arguments = new MarketLocalizableResourceArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceOperationQueryBuilder(IQuery<MarketLocalizableResource> query) : base(query)
        {
            Arguments = new MarketLocalizableResourceArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceOperationQueryBuilder MarketLocalizableContent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableContentQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableContent>("marketLocalizableContent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableContent>(query);
            return this;
        }

        public MarketLocalizableResourceOperationQueryBuilder MarketLocalizations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder> build)
        {
            var query = new Query<MarketLocalization>("marketLocalizations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalization>(query);
            return this;
        }

        public MarketLocalizableResourceOperationQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }
    }
}