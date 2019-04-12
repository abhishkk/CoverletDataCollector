﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.TestPlatform.Extensions.CoverletCoverageDataCollector.Utilities
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    /// <summary>
    /// Test platform eqttrace
    /// </summary>
    internal class TestPlatformEqtTrace
    {
        public bool IsInfoEnabled => EqtTrace.IsInfoEnabled;
        public bool IsVerboseEnabled => EqtTrace.IsVerboseEnabled;

        /// <summary>
        /// Verbose logger
        /// </summary>
        /// <param name="format">Format</param>
        /// <param name="args">Args</param>
        public void Verbose(string format, params object[] args)
        {
            EqtTrace.Verbose(format, args);
        }

        /// <summary>
        /// Warning logger
        /// </summary>
        /// <param name="format">Format</param>
        /// <param name="args">Args</param>
        public void Warning(string format, params object[] args)
        {
            EqtTrace.Warning(format, args);
        }

        /// <summary>
        /// Info logger
        /// </summary>
        /// <param name="format">Format</param>
        /// <param name="args">Args</param>
        public void Info(string format, params object[] args)
        {
            EqtTrace.Info(format, args);
        }
    }
}