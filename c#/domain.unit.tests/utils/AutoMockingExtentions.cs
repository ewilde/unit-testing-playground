// -----------------------------------------------------------------------
// <copyright file="AutoMockingExtentions.cs">
// Copyright (c) 2013.
// </copyright>
// -----------------------------------------------------------------------
namespace domain.unit.tests.utils
{
    using StructureMap.AutoMocking;

    public class AutoMockingExtentions
    {
         public static RhinoAutoMocker<T> Subject<T>() where T : class
         {
             return new RhinoAutoMocker<T>(MockMode.AAA);
         }
    }
}