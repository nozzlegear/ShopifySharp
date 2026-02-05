#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents access permissions for a staff member.
/// </summary>
public enum StaffMemberPermission
{
    APPLICATIONS,
    CHANNELS,
    CREATE_AND_EDIT_CUSTOMERS,
    CREATE_AND_EDIT_GIFT_CARDS,
    CUSTOMERS,
    DASHBOARD,
    DEACTIVATE_GIFT_CARDS,
    DELETE_CUSTOMERS,
    DOMAINS,
    DRAFT_ORDERS,
    EDIT_ORDERS,
    ERASE_CUSTOMER_DATA,
    EXPORT_CUSTOMERS,
    EXPORT_GIFT_CARDS,
    [Obsolete("Use the list of the staff members explicit permissions returned in the `StaffMember.permissions.userPermissions` field instead of `full` permission.")]
    FULL,
    GIFT_CARDS,
    LINKS,
    LOCATIONS,
    VIEW_MARKETS,
    CREATE_AND_EDIT_MARKETS,
    DELETE_MARKETS,
    MARKETING,
    MARKETING_SECTION,
    MERGE_CUSTOMERS,
    ORDERS,
    OVERVIEWS,
    PAGES,
    PAY_ORDERS_BY_VAULTED_CARD,
    PREFERENCES,
    PRODUCTS,
    REPORTS,
    REQUEST_CUSTOMER_DATA,
    THEMES,
    [Obsolete("Unused.")]
    TRANSLATIONS,
}