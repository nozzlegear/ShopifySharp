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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CompanyContactSendWelcomeEmailOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactSendWelcomeEmailPayload, CompanyContactSendWelcomeEmailOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactSendWelcomeEmailPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactSendWelcomeEmailArgumentsBuilder Arguments { get; }
        protected override CompanyContactSendWelcomeEmailOperationQueryBuilder Self => this;

        public CompanyContactSendWelcomeEmailOperationQueryBuilder() : this("companyContactSendWelcomeEmail")
        {
        }

        public CompanyContactSendWelcomeEmailOperationQueryBuilder(string name) : base(new Query<CompanyContactSendWelcomeEmailPayload>(name))
        {
            Arguments = new CompanyContactSendWelcomeEmailArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactSendWelcomeEmailOperationQueryBuilder(IQuery<CompanyContactSendWelcomeEmailPayload> query) : base(query)
        {
            Arguments = new CompanyContactSendWelcomeEmailArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactSendWelcomeEmailOperationQueryBuilder CompanyContact(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("companyContact");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyContactSendWelcomeEmailOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}