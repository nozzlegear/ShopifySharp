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

        public DiscountAutomaticAppUpdateOperationQueryBuilder AutomaticAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("automaticAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticApp>(query);
            return this;
        }

        public DiscountAutomaticAppUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}