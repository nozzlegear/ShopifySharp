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
    public sealed class PurchasingEntityQueryBuilder : FieldsQueryBuilderBase<PurchasingEntity, PurchasingEntityQueryBuilder>
    {
        protected override PurchasingEntityQueryBuilder Self => this;

        public PurchasingEntityQueryBuilder() : this("purchasingEntity")
        {
        }

        public PurchasingEntityQueryBuilder(string name) : base(new Query<PurchasingEntity>(name))
        {
        }

        public PurchasingEntityQueryBuilder(IQuery<PurchasingEntity> query) : base(query)
        {
        }

        public PurchasingEntityQueryBuilder PurchasingEntity(Action<PurchasingEntityUnionCasesBuilder> build)
        {
            var query = new Query<PurchasingEntity>("purchasingEntity");
            var unionBuilder = new PurchasingEntityUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}