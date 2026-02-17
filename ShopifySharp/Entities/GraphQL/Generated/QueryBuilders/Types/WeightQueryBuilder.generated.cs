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
    public sealed class WeightQueryBuilder : FieldsQueryBuilderBase<Weight, WeightQueryBuilder>
    {
        protected override WeightQueryBuilder Self => this;

        public WeightQueryBuilder() : this("weight")
        {
        }

        public WeightQueryBuilder(string name) : base(new Query<Weight>(name))
        {
        }

        public WeightQueryBuilder(IQuery<Weight> query) : base(query)
        {
        }

        public WeightQueryBuilder Unit()
        {
            base.InnerQuery.AddField("unit");
            return this;
        }

        public WeightQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}