﻿#if CONTRACTS_FULL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace QuickGraph.Contracts
{
    [ContractClassFor(typeof(IMutableUndirectedGraph<,>))]
    sealed class IMutableUndirectedGraphContract<TVertex, TEdge>
        : IMutableUndirectedGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        #region IMutableUndirectedGraph<TVertex,TEdge> Members

        int IMutableUndirectedGraph<TVertex, TEdge>.RemoveAdjacentEdgeIf(
            TVertex vertex, 
            EdgePredicate<TVertex, TEdge> predicate)
        {
            IMutableUndirectedGraph<TVertex, TEdge> ithis = this;
            Contract.Requires(vertex != null);
            Contract.Requires(predicate != null);
            Contract.Ensures(Contract.Result<int>() == Contract.OldValue(Enumerable.Count(ithis.AdjacentEdges(vertex), e => predicate(e))));
            Contract.Ensures(Contract.ForAll(ithis.AdjacentEdges(vertex), v => !predicate(v)));

            return Contract.Result<int>();
        }

        void IMutableUndirectedGraph<TVertex, TEdge>.ClearAdjacentEdges(TVertex vertex)
        {
            IMutableUndirectedGraph<TVertex, TEdge> ithis = this;
            Contract.Requires(vertex != null);
            Contract.Ensures(ithis.AdjacentDegree(vertex) == 0);
        }
        #endregion

        #region IMutableEdgeListGraph<TVertex,TEdge> Members

        bool IMutableEdgeListGraph<TVertex, TEdge>.AddEdge(TEdge edge)
        {
            throw new NotImplementedException();
        }

        event EdgeEventHandler<TVertex, TEdge> IMutableEdgeListGraph<TVertex, TEdge>.EdgeAdded
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        int IMutableEdgeListGraph<TVertex, TEdge>.AddEdgeRange(IEnumerable<TEdge> edges)
        {
            throw new NotImplementedException();
        }

        bool IMutableEdgeListGraph<TVertex, TEdge>.RemoveEdge(TEdge edge)
        {
            throw new NotImplementedException();
        }

        event EdgeEventHandler<TVertex, TEdge> IMutableEdgeListGraph<TVertex, TEdge>.EdgeRemoved
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        int IMutableEdgeListGraph<TVertex, TEdge>.RemoveEdgeIf(EdgePredicate<TVertex, TEdge> predicate)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IMutableGraph<TVertex,TEdge> Members

        void IMutableGraph<TVertex, TEdge>.Clear()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IGraph<TVertex,TEdge> Members

        bool IGraph<TVertex, TEdge>.IsDirected
        {
            get { throw new NotImplementedException(); }
        }

        bool IGraph<TVertex, TEdge>.AllowParallelEdges
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IEdgeSet<TVertex,TEdge> Members

        bool IEdgeSet<TVertex, TEdge>.IsEdgesEmpty
        {
            get { throw new NotImplementedException(); }
        }

        int IEdgeSet<TVertex, TEdge>.EdgeCount
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<TEdge> IEdgeSet<TVertex, TEdge>.Edges
        {
            get { throw new NotImplementedException(); }
        }

        bool IEdgeSet<TVertex, TEdge>.ContainsEdge(TEdge edge)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IMutableVertexSet<TVertex> Members

        event VertexEventHandler<TVertex> IMutableVertexSet<TVertex>.VertexAdded
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        bool IMutableVertexSet<TVertex>.AddVertex(TVertex v)
        {
            throw new NotImplementedException();
        }

        int IMutableVertexSet<TVertex>.AddVertexRange(IEnumerable<TVertex> vertices)
        {
            throw new NotImplementedException();
        }

        event VertexEventHandler<TVertex> IMutableVertexSet<TVertex>.VertexRemoved
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        bool IMutableVertexSet<TVertex>.RemoveVertex(TVertex v)
        {
            throw new NotImplementedException();
        }

        int IMutableVertexSet<TVertex>.RemoveVertexIf(VertexPredicate<TVertex> pred)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IVertexSet<TVertex> Members

        bool IVertexSet<TVertex>.IsVerticesEmpty
        {
            get { throw new NotImplementedException(); }
        }

        int IVertexSet<TVertex>.VertexCount
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerable<TVertex> IVertexSet<TVertex>.Vertices
        {
            get { throw new NotImplementedException(); }
        }

        bool IVertexSet<TVertex>.ContainsVertex(TVertex vertex)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IUndirectedGraph<TVertex,TEdge> Members

        IEnumerable<TEdge> IUndirectedGraph<TVertex, TEdge>.AdjacentEdges(TVertex v)
        {
            throw new NotImplementedException();
        }

        int IUndirectedGraph<TVertex, TEdge>.AdjacentDegree(TVertex v)
        {
            throw new NotImplementedException();
        }

        bool IUndirectedGraph<TVertex, TEdge>.IsAdjacentEdgesEmpty(TVertex v)
        {
            throw new NotImplementedException();
        }

        TEdge IUndirectedGraph<TVertex, TEdge>.AdjacentEdge(TVertex v, int index)
        {
            throw new NotImplementedException();
        }

        bool IUndirectedGraph<TVertex, TEdge>.ContainsEdge(TVertex source, TVertex target)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
#endif