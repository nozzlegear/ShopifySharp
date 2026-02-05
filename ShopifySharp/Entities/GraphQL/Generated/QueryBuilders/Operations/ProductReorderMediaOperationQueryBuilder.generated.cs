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
    public sealed class ProductReorderMediaOperationQueryBuilder : FieldsQueryBuilderBase<ProductReorderMediaPayload, ProductReorderMediaOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductReorderMediaPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductReorderMediaArgumentsBuilder Arguments { get; }
        protected override ProductReorderMediaOperationQueryBuilder Self => this;

        public ProductReorderMediaOperationQueryBuilder() : this("productReorderMedia")
        {
        }

        public ProductReorderMediaOperationQueryBuilder(string name) : base(new Query<ProductReorderMediaPayload>(name))
        {
            Arguments = new ProductReorderMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductReorderMediaOperationQueryBuilder(IQuery<ProductReorderMediaPayload> query) : base(query)
        {
            Arguments = new ProductReorderMediaArgumentsBuilder(base.InnerQuery);
        }

        public ProductReorderMediaOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public ProductReorderMediaOperationQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductReorderMediaOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}