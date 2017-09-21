using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class User : ShopifyObject
    {
        /// <summary>
        /// Identifies if the user is the owner of the Shopify account.
        /// </summary>
        [JsonProperty("account_owner")]
        public bool? AccountOwner { get; set; }

        /// <summary>
        /// User specified description of oneself.
        /// </summary>
        [JsonProperty("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Email address associated with this account.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the account user.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The IM account address.
        /// </summary>
        [JsonProperty("im")]
        public string IM { get; set; }

        /// <summary>
        /// The last name of the account user.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The permissions that the account has. Users will either have "full" or "limited" permissions.
        /// <para>Limited permissions are scoped to a user in that they can only view certain parts of the Shopify Admin</para> 
        /// <para>The types of permissions a limited user can have are as follows:</para> 
        /// <para>dashboard: Can see Shop performance and statistics</para> 
        /// <para>orders: Can view and modify orders</para> 
        /// <para>customers: Can view and modify customers</para> 
        /// <para>marketing: Can view and modify marketing related products such as discount codes</para> 
        /// <para>products: Can view and modify products</para> 
        /// <para>gift_cards: Can view and modify gift cards</para> 
        /// <para>pages: Can view and modify shop pages</para> 
        /// <para>links: Can view and modify links and menus</para> 
        /// <para>themes: Can view and modify shop themes</para> 
        /// <para>applications: Can authorize the installation of third party applications</para> 
        /// <para>preferences: Can view the preferences and configuration of a shop</para> 
        /// <para>reports: Can view and create reports</para> 
        /// </summary>
        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        /// <summary>
        /// Phone number associated with the account.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// Whether or not this account will receive email announcements from Shopify.
        /// </summary>
        [JsonProperty("receive_announcements")]
        public bool? ReceiveAnnouncements { get; set; }

        /// <summary>
        /// Homepage or other web address
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The type that the account is:
        /// <para>regular - A normal account that can access the web admin</para> 
        /// <para>restricted - A user account that cannot access the web admin</para> 
        /// </summary>
        [JsonProperty("user_type")]
        public string UserType { get; set; }
    }
}
