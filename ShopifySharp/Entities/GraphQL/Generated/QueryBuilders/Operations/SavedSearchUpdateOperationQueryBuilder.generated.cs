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
    public sealed class SavedSearchUpdateOperationQueryBuilder : FieldsQueryBuilderBase<SavedSearchUpdatePayload, SavedSearchUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<SavedSearchUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SavedSearchUpdateArgumentsBuilder Arguments { get; }
        protected override SavedSearchUpdateOperationQueryBuilder Self => this;

        public SavedSearchUpdateOperationQueryBuilder() : this("savedSearchUpdate")
        {
        }

        public SavedSearchUpdateOperationQueryBuilder(string name) : base(new Query<SavedSearchUpdatePayload>(name))
        {
            Arguments = new SavedSearchUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchUpdateOperationQueryBuilder(IQuery<SavedSearchUpdatePayload> query) : base(query)
        {
            Arguments = new SavedSearchUpdateArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchUpdateOperationQueryBuilder SavedSearch(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("savedSearch");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public SavedSearchUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}