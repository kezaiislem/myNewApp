﻿using PFE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.ViewModel
{
    public class PhaseControlViewModel
    {
        public Phase phase { get; set; }

        public PhaseControlViewModel(Phase phase)
        {
            this.phase = phase;
        }
    }
}