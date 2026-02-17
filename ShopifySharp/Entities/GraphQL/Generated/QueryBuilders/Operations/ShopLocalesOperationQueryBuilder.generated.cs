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
    public sealed class ShopLocalesOperationQueryBuilder : FieldsQueryBuilderBase<ShopLocale, ShopLocalesOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopLocale>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ShopLocalesArgumentsBuilder Arguments { get; }
        protected override ShopLocalesOperationQueryBuilder Self => this;

        public ShopLocalesOperationQueryBuilder() : this("shopLocales")
        {
        }

        public ShopLocalesOperationQueryBuilder(string name) : base(new Query<ShopLocale>(name))
        {
            Arguments = new ShopLocalesArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocalesOperationQueryBuilder(IQuery<ShopLocale> query) : base(query)
        {
            Arguments = new ShopLocalesArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocalesOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopLocalesOperationQueryBuilder MarketWebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("marketWebPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public ShopLocalesOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ShopLocalesOperationQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public ShopLocalesOperationQueryBuilder Published()
        {
            base.InnerQuery.AddField("published");
            return this;
        }
    }
}