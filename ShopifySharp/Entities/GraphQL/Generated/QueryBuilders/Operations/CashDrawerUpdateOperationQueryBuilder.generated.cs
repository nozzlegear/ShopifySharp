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
    public sealed class CashDrawerUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CashDrawerUpdatePayload, CashDrawerUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CashDrawerUpdatePayload>, IHasArguments<CashDrawerUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CashDrawerUpdateArgumentsBuilder Arguments { get; }
        protected override CashDrawerUpdateOperationQueryBuilder Self => this;

        public CashDrawerUpdateOperationQueryBuilder() : this("cashDrawerUpdate")
        {
        }

        public CashDrawerUpdateOperationQueryBuilder(string name) : base(new Query<CashDrawerUpdatePayload>(name))
        {
            Arguments = new CashDrawerUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerUpdateOperationQueryBuilder(IQuery<CashDrawerUpdatePayload> query) : base(query)
        {
            Arguments = new CashDrawerUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerUpdateOperationQueryBuilder SetArguments(Action<CashDrawerUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerUpdateOperationQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public CashDrawerUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CashDrawerUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerUpdateUserError>(query);
            return this;
        }
    }
}