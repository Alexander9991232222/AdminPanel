﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models
{
    public interface IBaseModel
    {
        public long? Id { get; set; }
    }
}
