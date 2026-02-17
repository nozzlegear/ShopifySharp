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
    public sealed class CheckoutProfileQueryBuilder : FieldsQueryBuilderBase<CheckoutProfile, CheckoutProfileQueryBuilder>
    {
        protected override CheckoutProfileQueryBuilder Self => this;

        public CheckoutProfileQueryBuilder() : this("checkoutProfile")
        {
        }

        public CheckoutProfileQueryBuilder(string name) : base(new Query<CheckoutProfile>(name))
        {
        }

        public CheckoutProfileQueryBuilder(IQuery<CheckoutProfile> query) : base(query)
        {
        }

        public CheckoutProfileQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CheckoutProfileQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public CheckoutProfileQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CheckoutProfileQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CheckoutProfileQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CheckoutProfileQueryBuilder TypOspPagesActive()
        {
            base.InnerQuery.AddField("typOspPagesActive");
            return this;
        }

        public CheckoutProfileQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}