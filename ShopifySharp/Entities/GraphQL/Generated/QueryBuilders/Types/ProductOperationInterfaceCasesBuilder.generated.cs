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
    public sealed class ProductOperationInterfaceCasesBuilder : InterfaceCasesBuilderBase<IProductOperation, ProductOperationInterfaceCasesBuilder>
    {
        protected override ProductOperationInterfaceCasesBuilder Self => this;

        public ProductOperationInterfaceCasesBuilder(string fieldName = "productOperation") : this(new Query<IProductOperation>(fieldName))
        {
        }

        public ProductOperationInterfaceCasesBuilder(IQuery<IProductOperation> query) : base(query)
        {
        }

        public ProductOperationInterfaceCasesBuilder OnProductBundleOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("... on ProductBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ProductOperationInterfaceCasesBuilder OnProductDeleteOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder> build)
        {
            var query = new Query<ProductDeleteOperation>("... on ProductDeleteOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDeleteOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ProductOperationInterfaceCasesBuilder OnProductDuplicateOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder> build)
        {
            var query = new Query<ProductDuplicateOperation>("... on ProductDuplicateOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductDuplicateOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public ProductOperationInterfaceCasesBuilder OnProductSetOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder> build)
        {
            var query = new Query<ProductSetOperation>("... on ProductSetOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}