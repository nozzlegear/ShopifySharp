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

        public QueryRootProductOperationQueryBuilder OnProductBundleOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("... on ProductBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootProductOperationQueryBuilder OnProductDeleteOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder> build)
        {
            var query = new Query<ProductDeleteOperation>("... on ProductDeleteOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootProductOperationQueryBuilder OnProductDuplicateOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateOperation>("... on ProductDuplicateOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootProductOperationQueryBuilder OnProductSetOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder> build)
        {
            var query = new Query<ProductSetOperation>("... on ProductSetOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public QueryRootProductOperationQueryBuilder ProductOperation(Action<ProductOperationInterfaceCasesBuilder> build)
        {
            var query = new Query<IProductOperation>("productOperation");
            var unionBuilder = new ProductOperationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}