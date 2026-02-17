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
    public sealed class DiscountAutomaticAppUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticAppUpdatePayload, DiscountAutomaticAppUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticAppUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticAppUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticAppUpdateOperationQueryBuilder Self => this;

        public DiscountAutomaticAppUpdateOperationQueryBuilder() : this("discountAutomaticAppUpdate")
        {
        }

        public DiscountAutomaticAppUpdateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticAppUpdatePayload>(name))
        {
            Arguments = new DiscountAutomaticAppUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticAppUpdateOperationQueryBuilder(IQuery<DiscountAutomaticAppUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticAppUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticAppUpdateOperationQueryBuilder AutomaticAppDiscount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("automaticAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticApp>(query);
            return this;
        }

        public DiscountAutomaticAppUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}