﻿using AdminPanelService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Services
{
    public interface IBaseService<T>
    {
        abstract Task<IResult> GetList();

        abstract Task<IResult> GetById(long id);

        abstract Task<IResult> Set(T obj);

        abstract Task<IResult> Update(long id, T obj);

        abstract Task<IResult> Delete(long id);

        void SaveChange();

        T FindById(long id);
    }
}