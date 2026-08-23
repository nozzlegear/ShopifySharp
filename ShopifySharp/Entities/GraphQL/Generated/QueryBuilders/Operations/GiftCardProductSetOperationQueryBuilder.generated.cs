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
    public sealed class GiftCardProductSetOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardProductSetPayload, GiftCardProductSetOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardProductSetPayload>, IHasArguments<GiftCardProductSetArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardProductSetArgumentsBuilder Arguments { get; }
        protected override GiftCardProductSetOperationQueryBuilder Self => this;

        public GiftCardProductSetOperationQueryBuilder() : this("giftCardProductSet")
        {
        }

        public GiftCardProductSetOperationQueryBuilder(string name) : base(new Query<GiftCardProductSetPayload>(name))
        {
            Arguments = new GiftCardProductSetArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardProductSetOperationQueryBuilder(IQuery<GiftCardProductSetPayload> query) : base(query)
        {
            Arguments = new GiftCardProductSetArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardProductSetOperationQueryBuilder SetArguments(Action<GiftCardProductSetArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public GiftCardProductSetOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public GiftCardProductSetOperationQueryBuilder ProductSetOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder> build)
        {
            var query = new Query<ProductSetOperation>("productSetOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductSetOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductSetOperation>(query);
            return this;
        }

        public GiftCardProductSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardProductSetUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardProductSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardProductSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardProductSetUserError>(query);
            return this;
        }
    }
}