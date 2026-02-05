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
    public sealed class QuantityRulesDeletePayloadQueryBuilder : FieldsQueryBuilderBase<QuantityRulesDeletePayload, QuantityRulesDeletePayloadQueryBuilder>
    {
        protected override QuantityRulesDeletePayloadQueryBuilder Self => this;

        public QuantityRulesDeletePayloadQueryBuilder() : this("quantityRulesDeletePayload")
        {
        }

        public QuantityRulesDeletePayloadQueryBuilder(string name) : base(new Query<QuantityRulesDeletePayload>(name))
        {
        }

        public QuantityRulesDeletePayloadQueryBuilder(IQuery<QuantityRulesDeletePayload> query) : base(query)
        {
        }

        public QuantityRulesDeletePayloadQueryBuilder DeletedQuantityRulesVariantIds()
        {
            base.InnerQuery.AddField("deletedQuantityRulesVariantIds");
            return this;
        }

        public QuantityRulesDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityRuleUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityRuleUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityRuleUserError>(query);
            return this;
        }
    }
}