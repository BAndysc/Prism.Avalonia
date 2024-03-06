

using System;
using System.Runtime.Serialization;

namespace Prism.Regions
{
    /// <summary>
    /// Exception that's thrown when something goes wrong while Registering a View with a region name in the <see cref="RegionViewRegistry"/> class.
    /// </summary>
    [Serializable]
    public partial class ViewRegistrationException
    {
    }
}
