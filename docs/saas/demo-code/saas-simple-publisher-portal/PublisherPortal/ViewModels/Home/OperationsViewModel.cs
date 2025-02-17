﻿using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;

namespace PubisherPortal.ViewModels.Home
{
    public class OperationsViewModel
    {
        public Operation OperationStatus { get; set; }
        public IReadOnlyList<Operation> SubscriptionOperations { get; set; }
        public Subscription Subscription { get; set; }
    }
}
