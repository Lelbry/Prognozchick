﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StavluNaKonDushuMatery
{
    public partial class Com : Component
    {
        public Com()
        {
            InitializeComponent();
        }

        public Com(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
