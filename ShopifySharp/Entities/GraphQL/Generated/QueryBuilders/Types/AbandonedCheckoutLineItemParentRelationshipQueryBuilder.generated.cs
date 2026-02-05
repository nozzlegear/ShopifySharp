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
    public sealed class AbandonedCheckoutLineItemParentRelationshipQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutLineItemParentRelationship, AbandonedCheckoutLineItemParentRelationshipQueryBuilder>
    {
        protected override AbandonedCheckoutLineItemParentRelationshipQueryBuilder Self => this;

        public AbandonedCheckoutLineItemParentRelationshipQueryBuilder() : this("abandonedCheckoutLineItemParentRelationship")
        {
        }

        public AbandonedCheckoutLineItemParentRelationshipQueryBuilder(string name) : base(new Query<AbandonedCheckoutLineItemParentRelationship>(name))
        {
        }

        public AbandonedCheckoutLineItemParentRelationshipQueryBuilder(IQuery<AbandonedCheckoutLineItemParentRelationship> query) : base(query)
        {
        }

        public AbandonedCheckoutLineItemParentRelationshipQueryBuilder Parent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutLineItem>("parent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonedCheckoutLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutLineItem>(query);
            return this;
        }
    }
}