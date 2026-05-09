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
    public sealed class CashDrawerCreateOperationQueryBuilder : FieldsQueryBuilderBase<CashDrawerCreatePayload, CashDrawerCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CashDrawerCreatePayload>, IHasArguments<CashDrawerCreateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CashDrawerCreateArgumentsBuilder Arguments { get; }
        protected override CashDrawerCreateOperationQueryBuilder Self => this;

        public CashDrawerCreateOperationQueryBuilder() : this("cashDrawerCreate")
        {
        }

        public CashDrawerCreateOperationQueryBuilder(string name) : base(new Query<CashDrawerCreatePayload>(name))
        {
            Arguments = new CashDrawerCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerCreateOperationQueryBuilder(IQuery<CashDrawerCreatePayload> query) : base(query)
        {
            Arguments = new CashDrawerCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerCreateOperationQueryBuilder SetArguments(Action<CashDrawerCreateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerCreateOperationQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public CashDrawerCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CashDrawerCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerCreateUserError>(query);
            return this;
        }
    }
}