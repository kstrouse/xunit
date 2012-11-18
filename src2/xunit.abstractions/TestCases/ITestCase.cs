using System.Collections.Generic;

namespace Xunit.Abstractions
{
    /// <summary>
    /// Represents a single test case in the system. This test case usually represents a single test, but in
    /// the case of dynamically generated data for data driven tests, the test case may actually return
    /// multiple results when run.
    /// </summary>
    public interface ITestCase
    {
        /// <summary>
        /// Gets the assembly this test case belongs to.
        /// </summary>
        IAssemblyInfo Assembly { get; }

        /// <summary>
        /// Gets the display name of the test method.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets the display text for the reason a test is being skipped; if the test
        /// is not skipped, returns null.
        /// </summary>
        string SkipReason { get; }

        /// <summary>
        /// Gets the test collection this test case belongs to.
        /// </summary>
        ITestCollection TestCollection { get; }

        /// <summary>
        /// Gets the trait values associated with this test case. If
        /// there are none, or the framework does not support traits,
        /// this should return an empty dictionary (not null). This
        /// dictionary should be treated as read-only.
        /// </summary>
        IDictionary<string, string> Traits { get; }
    }
}