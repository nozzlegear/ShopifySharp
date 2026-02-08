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
    public sealed class CalculatedShippingLineQueryBuilder : FieldsQueryBuilderBase<CalculatedShippingLine, CalculatedShippingLineQueryBuilder>
    {
        protected override CalculatedShippingLineQueryBuilder Self => this;

        public CalculatedShippingLineQueryBuilder() : this("calculatedShippingLine")
        {
        }

        public CalculatedShippingLineQueryBuilder(string name) : base(new Query<CalculatedShippingLine>(name))
        {
        }

        public CalculatedShippingLineQueryBuilder(IQuery<CalculatedShippingLine> query) : base(query)
        {
        }

        public CalculatedShippingLineQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedShippingLineQueryBuilder Price(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("price");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CalculatedShippingLineQueryBuilder StagedStatus()
        {
            base.InnerQuery.AddField("stagedStatus");
            return this;
        }

        public CalculatedShippingLineQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}