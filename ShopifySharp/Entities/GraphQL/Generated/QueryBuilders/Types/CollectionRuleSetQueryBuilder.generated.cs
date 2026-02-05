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
    public sealed class CollectionRuleSetQueryBuilder : FieldsQueryBuilderBase<CollectionRuleSet, CollectionRuleSetQueryBuilder>
    {
        protected override CollectionRuleSetQueryBuilder Self => this;

        public CollectionRuleSetQueryBuilder() : this("collectionRuleSet")
        {
        }

        public CollectionRuleSetQueryBuilder(string name) : base(new Query<CollectionRuleSet>(name))
        {
        }

        public CollectionRuleSetQueryBuilder(IQuery<CollectionRuleSet> query) : base(query)
        {
        }

        public CollectionRuleSetQueryBuilder AppliedDisjunctively()
        {
            base.InnerQuery.AddField("appliedDisjunctively");
            return this;
        }

        public CollectionRuleSetQueryBuilder Rules(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleQueryBuilder> build)
        {
            var query = new Query<CollectionRule>("rules");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionRuleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionRule>(query);
            return this;
        }
    }
}