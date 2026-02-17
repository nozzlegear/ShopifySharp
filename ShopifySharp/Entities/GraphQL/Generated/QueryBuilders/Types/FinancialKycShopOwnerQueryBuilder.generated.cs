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
    public sealed class FinancialKycShopOwnerQueryBuilder : FieldsQueryBuilderBase<FinancialKycShopOwner, FinancialKycShopOwnerQueryBuilder>
    {
        protected override FinancialKycShopOwnerQueryBuilder Self => this;

        public FinancialKycShopOwnerQueryBuilder() : this("financialKycShopOwner")
        {
        }

        public FinancialKycShopOwnerQueryBuilder(string name) : base(new Query<FinancialKycShopOwner>(name))
        {
        }

        public FinancialKycShopOwnerQueryBuilder(IQuery<FinancialKycShopOwner> query) : base(query)
        {
        }

        public FinancialKycShopOwnerQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public FinancialKycShopOwnerQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public FinancialKycShopOwnerQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FinancialKycShopOwnerQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public FinancialKycShopOwnerQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }
    }
}