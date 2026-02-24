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
    public sealed class QueryRootProductsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootProductsCountQueryBuilder>, IHasArguments<QueryRootProductsCountArgumentsBuilder>
    {
        public QueryRootProductsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootProductsCountQueryBuilder Self => this;

        public QueryRootProductsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductsCountQueryBuilder SetArguments(Action<QueryRootProductsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootProductsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}