#nullable enable
namespace ShopifySharp.Entities;

/// <summary>
/// Contains details about the user who authorized an app when using the "online access" flow.
/// </summary>
public record AssociatedUser
{
    /// <summary>
	/// The user ID.
	/// </summary>
    public long Id { get; set; } = 0;

    /// <summary>
	/// The user's first name.
	/// </summary>
    public string? FirstName { get; set; } = null!;

    /// <summary>
	/// The user's last name.
	/// </summary>
    public string? LastName { get; set; } = null!;

    /// <summary>
	/// The user's email address.
	/// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
	/// Whether the user's email address has been verified by Shopify.
	/// </summary>
    public bool EmailVerified { get; set; } = false;

    /// <summary>
	/// Whether the user is the account owner of the store.
	/// </summary>
    public bool AccountOwner { get; set; } = false;

    /// <summary>
	/// The user's locale (e.g. "en").
	/// </summary>
    public string Locale { get; set; } = null!;

    /// <summary>
	/// Whether the user is a collaborator (i.e., a Shopify Partner or staff).
	/// </summary>
    public bool Collaborator { get; set; } = false;
}
