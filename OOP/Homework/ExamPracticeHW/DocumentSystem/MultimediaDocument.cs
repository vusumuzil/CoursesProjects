﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class MultimediaDocument : BinaryDocument
    {
        public int Length { get; set; }
    }
}
