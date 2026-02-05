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
    public sealed class DiscountAutomaticActivatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticActivatePayload, DiscountAutomaticActivatePayloadQueryBuilder>
    {
        protected override DiscountAutomaticActivatePayloadQueryBuilder Self => this;

        public DiscountAutomaticActivatePayloadQueryBuilder() : this("discountAutomaticActivatePayload")
        {
        }

        public DiscountAutomaticActivatePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticActivatePayload>(name))
        {
        }

        public DiscountAutomaticActivatePayloadQueryBuilder(IQuery<DiscountAutomaticActivatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticActivatePayloadQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticActivatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}