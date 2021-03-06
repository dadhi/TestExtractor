﻿using System.Collections.Generic;
using TestExtractor.Structure;
using TestExtractor.Structure.Enums;

namespace TestExtractor.Filter
{
    /// <summary>
    ///     Interface defining the API for a Filter Object
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        ///     Filter by Categories
        /// </summary>
        /// <typeparam name="T">Type of input object. Needs to be of <see cref="INode" /></typeparam>
        /// <param name="nodes">Nodes source to filter</param>
        /// <param name="categories">Category values to filter by</param>
        /// <returns>An <see cref="IFilterResult{T}" /></returns>
        IFilterResult<T> FilterCategories<T>(IList<T> nodes, IList<string> categories) where T : INode;

        /// <summary>
        ///     Filter by Assemblies
        /// </summary>
        /// <typeparam name="T">Type of input object. Needs to be of <see cref="INode" /></typeparam>
        /// <param name="nodes">Nodes source to filter</param>
        /// <param name="assemblies">Assembly name to filter by</param>
        /// <returns>An <see cref="IFilterResult{T}" /></returns>
        IFilterResult<T> FilterAssembly<T>(IList<T> nodes, IList<string> assemblies) where T : INode;

        /// <summary>
        ///     Filter by Node Types
        /// </summary>
        /// <typeparam name="T">Type of input object. Needs to be of <see cref="INode" /></typeparam>
        /// <param name="nodes">Nodes source to filter</param>
        /// <param name="nodeTypes">Node Types name to filter by</param>
        /// <returns>An <see cref="IFilterResult{T}" /></returns>
        IFilterResult<T> FilterNodeTypes<T>(IList<T> nodes, IList<NodeTypes> nodeTypes) where T : INode;

        /// <summary>
        ///     Filter out Ignored Nodes
        /// </summary>
        /// <typeparam name="T">Type of input object. Needs to be of <see cref="INode" /></typeparam>
        /// <param name="nodes">Nodes source to filter</param>
        /// <returns>An <see cref="IFilterResult{T}" /></returns>
        IFilterResult<T> FilterOutIgnores<T>(IList<T> nodes) where T : INode;
    }
}