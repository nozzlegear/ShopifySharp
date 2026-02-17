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
    public sealed class MetaobjectUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectUpdatePayload, MetaobjectUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectUpdateArgumentsBuilder Arguments { get; }
        protected override MetaobjectUpdateOperationQueryBuilder Self => this;

        public MetaobjectUpdateOperationQueryBuilder() : this("metaobjectUpdate")
        {
        }

        public MetaobjectUpdateOperationQueryBuilder(string name) : base(new Query<MetaobjectUpdatePayload>(name))
        {
            Arguments = new MetaobjectUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectUpdateOperationQueryBuilder(IQuery<MetaobjectUpdatePayload> query) : base(query)
        {
            Arguments = new MetaobjectUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectUpdateOperationQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}