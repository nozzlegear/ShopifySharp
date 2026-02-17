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
    [Obsolete("Use `fileUpdate` instead.")]
    public sealed class ProductDeleteMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductDeleteMediaPayload, ProductDeleteMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductDeleteMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductDeleteMediaArgumentsBuilder Arguments { get; }
        protected override ProductDeleteMediaOperationQueryBuilder Self => this;

        public ProductDeleteMediaOperationQueryBuilder() : this("productDeleteMedia")
        {
        }

        public ProductDeleteMediaOperationQueryBuilder(string name) : base(new Query<ProductDeleteMediaPayload>(name))
        {
            Arguments = new ProductDeleteMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductDeleteMediaOperationQueryBuilder(IQuery<ProductDeleteMediaPayload> query) : base(query)
        {
            Arguments = new ProductDeleteMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductDeleteMediaOperationQueryBuilder DeletedMediaIds()
        {
            base.InnerQuery.AddField("deletedMediaIds");
            return this;
        }

        public ProductDeleteMediaOperationQueryBuilder DeletedProductImageIds()
        {
            base.InnerQuery.AddField("deletedProductImageIds");
            return this;
        }

        public ProductDeleteMediaOperationQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductDeleteMediaOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductDeleteMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}