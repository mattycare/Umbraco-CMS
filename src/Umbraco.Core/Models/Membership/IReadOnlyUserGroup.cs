using System.Collections.Generic;

namespace Umbraco.Core.Models.Membership
{
    /// <summary>
    /// A readonly user group providing basic information
    /// </summary>
    public interface IReadOnlyUserGroup
    {
        string Name { get; }
        string Icon { get; }
        int Id { get; }
        int? StartContentId { get; }
        int? StartMediaId { get; }

        /// <summary>
        /// The alias
        /// </summary>
        string Alias { get; }

        IEnumerable<string> AllowedSections { get; }
    }
}