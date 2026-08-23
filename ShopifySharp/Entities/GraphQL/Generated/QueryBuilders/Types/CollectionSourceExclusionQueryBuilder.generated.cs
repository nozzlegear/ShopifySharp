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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CollectionSourceExclusionQueryBuilder : FieldsQueryBuilderBase<CollectionSourceExclusion, CollectionSourceExclusionQueryBuilder>
    {
        protected override CollectionSourceExclusionQueryBuilder Self => this;

        public CollectionSourceExclusionQueryBuilder() : this("collectionSourceExclusion")
        {
        }

        public CollectionSourceExclusionQueryBuilder(string name) : base(new Query<CollectionSourceExclusion>(name))
        {
        }

        public CollectionSourceExclusionQueryBuilder(IQuery<CollectionSourceExclusion> query) : base(query)
        {
        }

        public CollectionSourceExclusionQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceExclusionQueryBuilder Selections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionExclusionProductSelectionConnection>("selections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionExclusionProductSelectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionExclusionProductSelectionConnection>(query);
            return this;
        }

        public CollectionSourceExclusionQueryBuilder Conditions(Action<CollectionSourceExclusionConditionInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionSourceExclusionCondition>("conditions");
            var unionBuilder = new CollectionSourceExclusionConditionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}