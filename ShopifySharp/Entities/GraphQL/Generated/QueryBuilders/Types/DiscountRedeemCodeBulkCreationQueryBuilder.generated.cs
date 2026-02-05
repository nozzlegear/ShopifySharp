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
    public sealed class DiscountRedeemCodeBulkCreationQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreation, DiscountRedeemCodeBulkCreationQueryBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationQueryBuilder() : this("discountRedeemCodeBulkCreation")
        {
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreation>(name))
        {
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder(IQuery<DiscountRedeemCodeBulkCreation> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder Codes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCodeConnection>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder CodesCount()
        {
            base.InnerQuery.AddField("codesCount");
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder DiscountCode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("discountCode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DiscountRedeemCodeBulkCreationQueryBuilder ImportedCount()
        {
            base.InnerQuery.AddField("importedCount");
            return this;
        }
    }
}