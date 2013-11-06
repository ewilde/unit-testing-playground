// -----------------------------------------------------------------------
// <copyright file="IService.cs">
// Copyright (c) 2013.
// </copyright>
// -----------------------------------------------------------------------
namespace domain.Services
{
    using domain.Model;

    public interface IService<T>
    {
        void Save(T entity);
    }
}