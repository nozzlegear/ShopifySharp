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

        public DiscountCodeAppCreateOperationQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}