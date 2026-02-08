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
    public sealed class DiscountCodeAppCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeAppCreatePayload, DiscountCodeAppCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeAppCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeAppCreateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeAppCreateOperationQueryBuilder Self => this;

        public DiscountCodeAppCreateOperationQueryBuilder() : this("discountCodeAppCreate")
        {
        }

        public DiscountCodeAppCreateOperationQueryBuilder(string name) : base(new Query<DiscountCodeAppCreatePayload>(name))
        {
            Arguments = new DiscountCodeAppCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeAppCreateOperationQueryBuilder(IQuery<DiscountCodeAppCreatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeAppCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeAppCreateOperationQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}