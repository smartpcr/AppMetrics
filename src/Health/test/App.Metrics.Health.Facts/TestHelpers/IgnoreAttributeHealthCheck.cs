﻿// <copyright file="IgnoreAttributeHealthCheck.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Metrics.Health.Facts.TestHelpers
{
    [Obsolete]
    public class IgnoreAttributeHealthCheck : HealthCheck
    {
        public IgnoreAttributeHealthCheck()
            : base("Referencing Assembly - Sample Healthy") { }

        protected override ValueTask<HealthCheckResult> CheckAsync(CancellationToken token = default)
        {
            return new ValueTask<HealthCheckResult>(HealthCheckResult.Healthy("OK"));
        }
    }
}