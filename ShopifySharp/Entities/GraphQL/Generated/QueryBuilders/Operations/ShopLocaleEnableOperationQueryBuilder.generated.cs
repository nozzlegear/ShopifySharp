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
    public sealed class ShopLocaleEnableOperationQueryBuilder : FieldsQueryBuilderBase<ShopLocaleEnablePayload, ShopLocaleEnableOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopLocaleEnablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopLocaleEnableArgumentsBuilder Arguments { get; }
        protected override ShopLocaleEnableOperationQueryBuilder Self => this;

        public ShopLocaleEnableOperationQueryBuilder() : this("shopLocaleEnable")
        {
        }

        public ShopLocaleEnableOperationQueryBuilder(string name) : base(new Query<ShopLocaleEnablePayload>(name))
        {
            Arguments = new ShopLocaleEnableArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleEnableOperationQueryBuilder(IQuery<ShopLocaleEnablePayload> query) : base(query)
        {
            Arguments = new ShopLocaleEnableArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleEnableOperationQueryBuilder ShopLocale(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("shopLocale");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public ShopLocaleEnableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}