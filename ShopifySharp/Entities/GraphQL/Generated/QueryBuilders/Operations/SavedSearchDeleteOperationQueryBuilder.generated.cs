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
    public sealed class SavedSearchDeleteOperationQueryBuilder : FieldsQueryBuilderBase<SavedSearchDeletePayload, SavedSearchDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<SavedSearchDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SavedSearchDeleteArgumentsBuilder Arguments { get; }
        protected override SavedSearchDeleteOperationQueryBuilder Self => this;

        public SavedSearchDeleteOperationQueryBuilder() : this("savedSearchDelete")
        {
        }

        public SavedSearchDeleteOperationQueryBuilder(string name) : base(new Query<SavedSearchDeletePayload>(name))
        {
            Arguments = new SavedSearchDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchDeleteOperationQueryBuilder(IQuery<SavedSearchDeletePayload> query) : base(query)
        {
            Arguments = new SavedSearchDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchDeleteOperationQueryBuilder DeletedSavedSearchId()
        {
            base.InnerQuery.AddField("deletedSavedSearchId");
            return this;
        }

        public SavedSearchDeleteOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public SavedSearchDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}