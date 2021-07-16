﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.AspNet.OData.Builder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Jetsons.Models
{
    public class company
    {
        [Key]
        public string stockSymbol { get; set; }

        public string name { get; set; }

        public DateTime incorporated { get; set; }

        [Contained]
        public List<employee> employees { get; set; }

    }
}