﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using App.Metrics.ReservoirSampling;

namespace App.Metrics.Core.Options
{
    /// <summary>
    ///     Configuration of a Metric that will be measured using a reservoir sampling type
    /// </summary>
    public abstract class MetricValueWithSamplingOption : MetricValueOptions
    {
        /// <summary>
        ///     Gets or sets an <see cref="IReservoir" /> implementation for sampling.
        /// </summary>
        /// <value>
        ///     The reservoir instance to use for sampling.
        /// </value>
        /// <remarks>
        ///     Reservoir sampling avoids unbound memory usage, allows metrics to be generated from a reservoir of values.
        /// </remarks>
        public Lazy<IReservoir> Reservoir { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has a reservoir set.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has reservoir; otherwise, <c>false</c>.
        /// </value>
        public bool HasReservoir => Reservoir != null;
    }
}