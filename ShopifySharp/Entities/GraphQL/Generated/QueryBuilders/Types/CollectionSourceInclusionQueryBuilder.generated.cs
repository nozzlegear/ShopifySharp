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
    public sealed class CollectionSourceInclusionQueryBuilder : FieldsQueryBuilderBase<CollectionSourceInclusion, CollectionSourceInclusionQueryBuilder>
    {
        protected override CollectionSourceInclusionQueryBuilder Self => this;

        public CollectionSourceInclusionQueryBuilder() : this("collectionSourceInclusion")
        {
        }

        public CollectionSourceInclusionQueryBuilder(string name) : base(new Query<CollectionSourceInclusion>(name))
        {
        }

        public CollectionSourceInclusionQueryBuilder(IQuery<CollectionSourceInclusion> query) : base(query)
        {
        }

        public CollectionSourceInclusionQueryBuilder MatchType()
        {
            base.InnerQuery.AddField("matchType");
            return this;
        }

        public CollectionSourceInclusionQueryBuilder Selections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionInclusionProductSelectionConnection>("selections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionInclusionProductSelectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionInclusionProductSelectionConnection>(query);
            return this;
        }

        public CollectionSourceInclusionQueryBuilder Conditions(Action<CollectionSourceInclusionConditionInterfaceCasesBuilder> build)
        {
            var query = new Query<ICollectionSourceInclusionCondition>("conditions");
            var unionBuilder = new CollectionSourceInclusionConditionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}