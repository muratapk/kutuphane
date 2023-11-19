﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
    public interface IGenericService<T>
    { 
       void TAdd(T entity);
       void TUpdate(T entity);
       void TDelete(T entity);
       List<T> TGetAll();
       T TGetById(int id);


    }
}