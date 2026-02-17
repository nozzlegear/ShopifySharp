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
    public sealed class MenuUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MenuUpdatePayload, MenuUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MenuUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MenuUpdateArgumentsBuilder Arguments { get; }
        protected override MenuUpdateOperationQueryBuilder Self => this;

        public MenuUpdateOperationQueryBuilder() : this("menuUpdate")
        {
        }

        public MenuUpdateOperationQueryBuilder(string name) : base(new Query<MenuUpdatePayload>(name))
        {
            Arguments = new MenuUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MenuUpdateOperationQueryBuilder(IQuery<MenuUpdatePayload> query) : base(query)
        {
            Arguments = new MenuUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MenuUpdateOperationQueryBuilder Menu(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuUpdateUserError>(query);
            return this;
        }
    }
}