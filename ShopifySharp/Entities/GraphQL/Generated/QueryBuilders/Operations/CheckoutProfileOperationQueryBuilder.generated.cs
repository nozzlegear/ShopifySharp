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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CheckoutProfileOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutProfile, CheckoutProfileOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutProfile>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CheckoutProfileArgumentsBuilder Arguments { get; }
        protected override CheckoutProfileOperationQueryBuilder Self => this;

        public CheckoutProfileOperationQueryBuilder() : this("checkoutProfile")
        {
        }

        public CheckoutProfileOperationQueryBuilder(string name) : base(new Query<CheckoutProfile>(name))
        {
            Arguments = new CheckoutProfileArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutProfileOperationQueryBuilder(IQuery<CheckoutProfile> query) : base(query)
        {
            Arguments = new CheckoutProfileArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutProfileOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder EditedAt()
        {
            base.InnerQuery.AddField("editedAt");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder IsPublished()
        {
            base.InnerQuery.AddField("isPublished");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder TypOspPagesActive()
        {
            base.InnerQuery.AddField("typOspPagesActive");
            return this;
        }

        public CheckoutProfileOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}