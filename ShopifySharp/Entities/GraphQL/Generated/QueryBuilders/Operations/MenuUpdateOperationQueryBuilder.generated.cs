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

        public MenuUpdateOperationQueryBuilder Menu(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuUpdateUserError>(query);
            return this;
        }
    }
}