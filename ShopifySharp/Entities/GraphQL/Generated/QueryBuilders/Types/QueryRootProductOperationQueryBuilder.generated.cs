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
    public sealed class QueryRootProductOperationQueryBuilder : FieldsQueryBuilderBase<IProductOperation, QueryRootProductOperationQueryBuilder>, IHasArguments<QueryRootProductOperationArgumentsBuilder>
    {
        public QueryRootProductOperationArgumentsBuilder Arguments { get; }
        protected override QueryRootProductOperationQueryBuilder Self => this;

        public QueryRootProductOperationQueryBuilder(string name) : base(new Query<IProductOperation>(name))
        {
            Arguments = new QueryRootProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductOperationQueryBuilder(IQuery<IProductOperation> query) : base(query)
        {
            Arguments = new QueryRootProductOperationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductOperationQueryBuilder SetArguments(Action<QueryRootProductOperationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootProductOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}