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
    public sealed class MetafieldReferenceExchangeV2sQueryBuilder : FieldsQueryBuilderBase<ExchangeV2Connection, MetafieldReferenceExchangeV2sQueryBuilder>, IHasArguments<MetafieldReferenceExchangeV2sArgumentsBuilder>
    {
        public MetafieldReferenceExchangeV2sArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceExchangeV2sQueryBuilder Self => this;

        public MetafieldReferenceExchangeV2sQueryBuilder(string name) : base(new Query<ExchangeV2Connection>(name))
        {
            Arguments = new MetafieldReferenceExchangeV2sArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceExchangeV2sQueryBuilder(IQuery<ExchangeV2Connection> query) : base(query)
        {
            Arguments = new MetafieldReferenceExchangeV2sArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceExchangeV2sQueryBuilder SetArguments(Action<MetafieldReferenceExchangeV2sArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceExchangeV2sQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2EdgeQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Edge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2EdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Edge>(query);
            return this;
        }

        public MetafieldReferenceExchangeV2sQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder> build)
        {
            var query = new Query<ExchangeV2>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2>(query);
            return this;
        }

        public MetafieldReferenceExchangeV2sQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}