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
    public sealed class CollectionSubCollectionEligibilityQueryBuilder : FieldsQueryBuilderBase<CollectionSubCollectionEligibility, CollectionSubCollectionEligibilityQueryBuilder>
    {
        protected override CollectionSubCollectionEligibilityQueryBuilder Self => this;

        public CollectionSubCollectionEligibilityQueryBuilder() : this("collectionSubCollectionEligibility")
        {
        }

        public CollectionSubCollectionEligibilityQueryBuilder(string name) : base(new Query<CollectionSubCollectionEligibility>(name))
        {
        }

        public CollectionSubCollectionEligibilityQueryBuilder(IQuery<CollectionSubCollectionEligibility> query) : base(query)
        {
        }

        public CollectionSubCollectionEligibilityQueryBuilder Exclusion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionEligibilityStateQueryBuilder> build)
        {
            var query = new Query<CollectionSubCollectionEligibilityState>("exclusion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionEligibilityStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSubCollectionEligibilityState>(query);
            return this;
        }

        public CollectionSubCollectionEligibilityQueryBuilder Inclusion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionEligibilityStateQueryBuilder> build)
        {
            var query = new Query<CollectionSubCollectionEligibilityState>("inclusion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionEligibilityStateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSubCollectionEligibilityState>(query);
            return this;
        }
    }
}