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
    public sealed class DiscountCodeAppUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeAppUpdatePayload, DiscountCodeAppUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeAppUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeAppUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeAppUpdateOperationQueryBuilder Self => this;

        public DiscountCodeAppUpdateOperationQueryBuilder() : this("discountCodeAppUpdate")
        {
        }

        public DiscountCodeAppUpdateOperationQueryBuilder(string name) : base(new Query<DiscountCodeAppUpdatePayload>(name))
        {
            Arguments = new DiscountCodeAppUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeAppUpdateOperationQueryBuilder(IQuery<DiscountCodeAppUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeAppUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeAppUpdateOperationQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}