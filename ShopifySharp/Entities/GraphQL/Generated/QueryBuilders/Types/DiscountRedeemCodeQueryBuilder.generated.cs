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
    public sealed class DiscountRedeemCodeQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCode, DiscountRedeemCodeQueryBuilder>
    {
        protected override DiscountRedeemCodeQueryBuilder Self => this;

        public DiscountRedeemCodeQueryBuilder() : this("discountRedeemCode")
        {
        }

        public DiscountRedeemCodeQueryBuilder(string name) : base(new Query<DiscountRedeemCode>(name))
        {
        }

        public DiscountRedeemCodeQueryBuilder(IQuery<DiscountRedeemCode> query) : base(query)
        {
        }

        public DiscountRedeemCodeQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountRedeemCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DiscountRedeemCodeQueryBuilder CreatedBy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("createdBy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public DiscountRedeemCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}