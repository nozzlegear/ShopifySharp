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
    public sealed class PriceRuleShareableUrlQueryBuilder : FieldsQueryBuilderBase<PriceRuleShareableUrl, PriceRuleShareableUrlQueryBuilder>
    {
        protected override PriceRuleShareableUrlQueryBuilder Self => this;

        public PriceRuleShareableUrlQueryBuilder() : this("priceRuleShareableUrl")
        {
        }

        public PriceRuleShareableUrlQueryBuilder(string name) : base(new Query<PriceRuleShareableUrl>(name))
        {
        }

        public PriceRuleShareableUrlQueryBuilder(IQuery<PriceRuleShareableUrl> query) : base(query)
        {
        }

        public PriceRuleShareableUrlQueryBuilder TargetItemImage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("targetItemImage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public PriceRuleShareableUrlQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public PriceRuleShareableUrlQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public PriceRuleShareableUrlQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}