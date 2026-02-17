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
    public sealed class ShopLocaleDisableOperationQueryBuilder : FieldsQueryBuilderBase<ShopLocaleDisablePayload, ShopLocaleDisableOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopLocaleDisablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopLocaleDisableArgumentsBuilder Arguments { get; }
        protected override ShopLocaleDisableOperationQueryBuilder Self => this;

        public ShopLocaleDisableOperationQueryBuilder() : this("shopLocaleDisable")
        {
        }

        public ShopLocaleDisableOperationQueryBuilder(string name) : base(new Query<ShopLocaleDisablePayload>(name))
        {
            Arguments = new ShopLocaleDisableArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleDisableOperationQueryBuilder(IQuery<ShopLocaleDisablePayload> query) : base(query)
        {
            Arguments = new ShopLocaleDisableArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleDisableOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopLocaleDisableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}