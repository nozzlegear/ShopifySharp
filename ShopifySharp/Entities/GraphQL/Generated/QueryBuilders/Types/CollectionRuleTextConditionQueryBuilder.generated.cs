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
    public sealed class CollectionRuleTextConditionQueryBuilder : FieldsQueryBuilderBase<CollectionRuleTextCondition, CollectionRuleTextConditionQueryBuilder>
    {
        protected override CollectionRuleTextConditionQueryBuilder Self => this;

        public CollectionRuleTextConditionQueryBuilder() : this("collectionRuleTextCondition")
        {
        }

        public CollectionRuleTextConditionQueryBuilder(string name) : base(new Query<CollectionRuleTextCondition>(name))
        {
        }

        public CollectionRuleTextConditionQueryBuilder(IQuery<CollectionRuleTextCondition> query) : base(query)
        {
        }

        public CollectionRuleTextConditionQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}