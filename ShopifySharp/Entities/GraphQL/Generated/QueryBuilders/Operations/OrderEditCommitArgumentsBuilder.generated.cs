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
    public sealed class OrderEditCommitArgumentsBuilder : ArgumentsBuilderBase<OrderEditCommitPayload, OrderEditCommitArgumentsBuilder>
    {
        protected override OrderEditCommitArgumentsBuilder Self => this;

        public OrderEditCommitArgumentsBuilder(IQuery<OrderEditCommitPayload> query) : base(query)
        {
        }

        public OrderEditCommitArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public OrderEditCommitArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public OrderEditCommitArgumentsBuilder StaffNote(string? staffNote)
        {
            base.InnerQuery.AddArgument("staffNote", staffNote);
            return this;
        }
    }
}