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
    public sealed class QueryRootPublishedProductsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootPublishedProductsCountQueryBuilder>, IHasArguments<QueryRootPublishedProductsCountArgumentsBuilder>
    {
        public QueryRootPublishedProductsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootPublishedProductsCountQueryBuilder Self => this;

        public QueryRootPublishedProductsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootPublishedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPublishedProductsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootPublishedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPublishedProductsCountQueryBuilder SetArguments(Action<QueryRootPublishedProductsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPublishedProductsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootPublishedProductsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}