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
    public sealed class CollectionRuleConditionsRuleObjectQueryBuilder : FieldsQueryBuilderBase<CollectionRuleConditionsRuleObject, CollectionRuleConditionsRuleObjectQueryBuilder>
    {
        protected override CollectionRuleConditionsRuleObjectQueryBuilder Self => this;

        public CollectionRuleConditionsRuleObjectQueryBuilder() : this("collectionRuleConditionsRuleObject")
        {
        }

        public CollectionRuleConditionsRuleObjectQueryBuilder(string name) : base(new Query<CollectionRuleConditionsRuleObject>(name))
        {
        }

        public CollectionRuleConditionsRuleObjectQueryBuilder(IQuery<CollectionRuleConditionsRuleObject> query) : base(query)
        {
        }

        public CollectionRuleConditionsRuleObjectQueryBuilder CollectionRuleConditionsRuleObject(Action<CollectionRuleConditionsRuleObjectUnionCasesBuilder> build)
        {
            var query = new Query<CollectionRuleConditionsRuleObject>("collectionRuleConditionsRuleObject");
            var unionBuilder = new CollectionRuleConditionsRuleObjectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}