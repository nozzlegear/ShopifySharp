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

        public DiscountCodeAppUpdateOperationQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}