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
    public sealed class DistanceQueryBuilder : FieldsQueryBuilderBase<Distance, DistanceQueryBuilder>
    {
        protected override DistanceQueryBuilder Self => this;

        public DistanceQueryBuilder() : this("distance")
        {
        }

        public DistanceQueryBuilder(string name) : base(new Query<Distance>(name))
        {
        }

        public DistanceQueryBuilder(IQuery<Distance> query) : base(query)
        {
        }

        public DistanceQueryBuilder Unit()
        {
            base.InnerQuery.AddField("unit");
            return this;
        }

        public DistanceQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}