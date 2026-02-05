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
    public sealed class CollectionRuleMetafieldConditionQueryBuilder : FieldsQueryBuilderBase<CollectionRuleMetafieldCondition, CollectionRuleMetafieldConditionQueryBuilder>
    {
        protected override CollectionRuleMetafieldConditionQueryBuilder Self => this;

        public CollectionRuleMetafieldConditionQueryBuilder() : this("collectionRuleMetafieldCondition")
        {
        }

        public CollectionRuleMetafieldConditionQueryBuilder(string name) : base(new Query<CollectionRuleMetafieldCondition>(name))
        {
        }

        public CollectionRuleMetafieldConditionQueryBuilder(IQuery<CollectionRuleMetafieldCondition> query) : base(query)
        {
        }

        public CollectionRuleMetafieldConditionQueryBuilder MetafieldDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("metafieldDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }
    }
}