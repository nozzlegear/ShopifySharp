#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `fileUpdate` instead.")]
    public sealed class ProductUpdateMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductUpdateMediaPayload, ProductUpdateMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductUpdateMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductUpdateMediaArgumentsBuilder Arguments { get; }
        protected override ProductUpdateMediaOperationQueryBuilder Self => this;

        public ProductUpdateMediaOperationQueryBuilder() : this("productUpdateMedia")
        {
        }

        public ProductUpdateMediaOperationQueryBuilder(string name) : base(new Query<ProductUpdateMediaPayload>(name))
        {
            Arguments = new ProductUpdateMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductUpdateMediaOperationQueryBuilder(IQuery<ProductUpdateMediaPayload> query) : base(query)
        {
            Arguments = new ProductUpdateMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductUpdateMediaOperationQueryBuilder Media(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("media");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public ProductUpdateMediaOperationQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductUpdateMediaOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductUpdateMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}