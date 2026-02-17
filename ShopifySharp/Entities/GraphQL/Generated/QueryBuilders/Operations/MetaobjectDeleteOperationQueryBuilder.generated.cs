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
    public sealed class MetaobjectDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectDeletePayload, MetaobjectDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectDeleteArgumentsBuilder Arguments { get; }
        protected override MetaobjectDeleteOperationQueryBuilder Self => this;

        public MetaobjectDeleteOperationQueryBuilder() : this("metaobjectDelete")
        {
        }

        public MetaobjectDeleteOperationQueryBuilder(string name) : base(new Query<MetaobjectDeletePayload>(name))
        {
            Arguments = new MetaobjectDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDeleteOperationQueryBuilder(IQuery<MetaobjectDeletePayload> query) : base(query)
        {
            Arguments = new MetaobjectDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MetaobjectDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}