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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CollectionRuleConditionObjectQueryBuilder : FieldsQueryBuilderBase<CollectionRuleConditionObject, CollectionRuleConditionObjectQueryBuilder>
    {
        protected override CollectionRuleConditionObjectQueryBuilder Self => this;

        public CollectionRuleConditionObjectQueryBuilder() : this("collectionRuleConditionObject")
        {
        }

        public CollectionRuleConditionObjectQueryBuilder(string name) : base(new Query<CollectionRuleConditionObject>(name))
        {
        }

        public CollectionRuleConditionObjectQueryBuilder(IQuery<CollectionRuleConditionObject> query) : base(query)
        {
        }

        public CollectionRuleConditionObjectQueryBuilder CollectionRuleConditionObject(Action<CollectionRuleConditionObjectUnionCasesBuilder> build)
        {
            var query = new Query<CollectionRuleConditionObject>("collectionRuleConditionObject");
            var unionBuilder = new CollectionRuleConditionObjectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}