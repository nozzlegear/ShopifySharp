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
    public sealed class CountryHarmonizedSystemCodeEdgeQueryBuilder : FieldsQueryBuilderBase<CountryHarmonizedSystemCodeEdge, CountryHarmonizedSystemCodeEdgeQueryBuilder>
    {
        protected override CountryHarmonizedSystemCodeEdgeQueryBuilder Self => this;

        public CountryHarmonizedSystemCodeEdgeQueryBuilder() : this("countryHarmonizedSystemCodeEdge")
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder(string name) : base(new Query<CountryHarmonizedSystemCodeEdge>(name))
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder(IQuery<CountryHarmonizedSystemCodeEdge> query) : base(query)
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCode>(query);
            return this;
        }
    }
}