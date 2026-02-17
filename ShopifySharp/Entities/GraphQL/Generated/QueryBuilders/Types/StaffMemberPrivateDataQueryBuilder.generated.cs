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
    public sealed class StaffMemberPrivateDataQueryBuilder : FieldsQueryBuilderBase<StaffMemberPrivateData, StaffMemberPrivateDataQueryBuilder>
    {
        protected override StaffMemberPrivateDataQueryBuilder Self => this;

        public StaffMemberPrivateDataQueryBuilder() : this("staffMemberPrivateData")
        {
        }

        public StaffMemberPrivateDataQueryBuilder(string name) : base(new Query<StaffMemberPrivateData>(name))
        {
        }

        public StaffMemberPrivateDataQueryBuilder(IQuery<StaffMemberPrivateData> query) : base(query)
        {
        }

        public StaffMemberPrivateDataQueryBuilder AccountSettingsUrl()
        {
            base.InnerQuery.AddField("accountSettingsUrl");
            return this;
        }

        public StaffMemberPrivateDataQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Theres no alternative field to use instead.")]
        public StaffMemberPrivateDataQueryBuilder Permissions()
        {
            base.InnerQuery.AddField("permissions");
            return this;
        }
    }
}