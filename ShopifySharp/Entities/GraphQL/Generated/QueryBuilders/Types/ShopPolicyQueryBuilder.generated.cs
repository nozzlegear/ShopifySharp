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
    public sealed class ShopPolicyQueryBuilder : FieldsQueryBuilderBase<ShopPolicy, ShopPolicyQueryBuilder>
    {
        protected override ShopPolicyQueryBuilder Self => this;

        public ShopPolicyQueryBuilder() : this("shopPolicy")
        {
        }

        public ShopPolicyQueryBuilder(string name) : base(new Query<ShopPolicy>(name))
        {
        }

        public ShopPolicyQueryBuilder(IQuery<ShopPolicy> query) : base(query)
        {
        }

        public ShopPolicyQueryBuilder Body()
        {
            base.InnerQuery.AddField("body");
            return this;
        }

        public ShopPolicyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopPolicyQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopPolicyQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ShopPolicyQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ShopPolicyQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public ShopPolicyQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ShopPolicyQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}