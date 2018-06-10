//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//---
namespace TestApp.Repositories
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T>:IDisposable
        where T : class
    {
        IEnumerable<T> GetAll();
        T Create(T item); 
        bool Update(int id,T item); 
        bool Delete(int id); 
    }
}
