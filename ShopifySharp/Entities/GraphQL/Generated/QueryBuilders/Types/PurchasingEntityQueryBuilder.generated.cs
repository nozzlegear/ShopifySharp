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