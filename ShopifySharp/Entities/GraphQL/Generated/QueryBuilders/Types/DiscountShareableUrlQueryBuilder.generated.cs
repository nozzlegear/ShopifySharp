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
    public sealed class DiscountShareableUrlQueryBuilder : FieldsQueryBuilderBase<DiscountShareableUrl, DiscountShareableUrlQueryBuilder>
    {
        protected override DiscountShareableUrlQueryBuilder Self => this;

        public DiscountShareableUrlQueryBuilder() : this("discountShareableUrl")
        {
        }

        public DiscountShareableUrlQueryBuilder(string name) : base(new Query<DiscountShareableUrl>(name))
        {
        }

        public DiscountShareableUrlQueryBuilder(IQuery<DiscountShareableUrl> query) : base(query)
        {
        }

        public DiscountShareableUrlQueryBuilder TargetItemImage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("targetItemImage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public DiscountShareableUrlQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public DiscountShareableUrlQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountShareableUrlQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}