﻿//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Tecwi">
// Copyright (c) Tecwi. All rights reserved.
// </copyright>
// <author>Elena Gertsiy</author>
//-------------------------------------------------------------------
namespace TestApp.Repositories
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T> : IDisposable
        where T : class
    {
        /// <summary>
        /// Get all records from a table
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Add a new record to a table
        /// </summary>
        /// <param name="item">the record wich need to added</param>
        /// <returns></returns>
        T Create(T item);

        /// <summary>
        /// Update a recod Employees table by id
        /// </summary>
        /// <param name="id">id of record wich need to update</param>
        /// <param name="item">a record wich update</param>
        /// <returns></returns>
        bool Update(int id,T item);

        /// <summary>
        /// Remove a record from Employees table by id
        /// </summary>
        /// <param name="id">id of record wich delete</param>
        /// <returns></returns>
        bool Delete(int id); 
    }
}
