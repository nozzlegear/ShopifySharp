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
    [Obsolete("Use `productUpdate` or `productSet` instead.")]
    public sealed class ProductCreateMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductCreateMediaPayload, ProductCreateMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductCreateMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductCreateMediaArgumentsBuilder Arguments { get; }
        protected override ProductCreateMediaOperationQueryBuilder Self => this;

        public ProductCreateMediaOperationQueryBuilder() : this("productCreateMedia")
        {
        }

        public ProductCreateMediaOperationQueryBuilder(string name) : base(new Query<ProductCreateMediaPayload>(name))
        {
            Arguments = new ProductCreateMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductCreateMediaOperationQueryBuilder(IQuery<ProductCreateMediaPayload> query) : base(query)
        {
            Arguments = new ProductCreateMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductCreateMediaOperationQueryBuilder Media(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("media");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public ProductCreateMediaOperationQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductCreateMediaOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductCreateMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}