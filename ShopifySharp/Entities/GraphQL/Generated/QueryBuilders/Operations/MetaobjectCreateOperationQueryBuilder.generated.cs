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
    public sealed class MetaobjectCreateOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectCreatePayload, MetaobjectCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectCreateArgumentsBuilder Arguments { get; }
        protected override MetaobjectCreateOperationQueryBuilder Self => this;

        public MetaobjectCreateOperationQueryBuilder() : this("metaobjectCreate")
        {
        }

        public MetaobjectCreateOperationQueryBuilder(string name) : base(new Query<MetaobjectCreatePayload>(name))
        {
            Arguments = new MetaobjectCreateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectCreateOperationQueryBuilder(IQuery<MetaobjectCreatePayload> query) : base(query)
        {
            Arguments = new MetaobjectCreateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectCreateOperationQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}