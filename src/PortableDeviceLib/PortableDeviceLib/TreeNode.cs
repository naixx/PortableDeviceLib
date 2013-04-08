#region License

/*
TreeNode.cs
Copyright (C) 2009 Vincent Lainé
 
This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace PortableDeviceLib
{
    public class TreeNode<T> : IEnumerable<TreeNode<T>>, ITreeNode
    {
        private readonly List<TreeNode<T>> childs;

        public TreeNode(TreeNode<T> parent)
        {
            childs = new List<TreeNode<T>>();
            Parent = parent;
        }

        public TreeNode(TreeNode<T> parent, T value)
            : this(parent)
        {
            Value = value;
        }

        public TreeNode<T> Parent { get; private set; }

        public TreeNode<T> this[int index]
        {
            get { return childs[index]; }
        }

        public IEnumerable<TreeNode<T>> Childs
        {
            get { return childs; }
        }

        public int Count
        {
            get { return childs.Count; }
        }

        public T Value { get; set; }

        public TreeNode<T> AddChild(T value)
        {
            var child = new TreeNode<T>(this, value);
            AddChild(child);
            return child;
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
                throw new ArgumentNullException("child");

            childs.Add(child);
        }

        public void RemoveChild(TreeNode<T> child)
        {
            if (child == null)
                throw new ArgumentNullException("child");

            childs.Remove(child);
        }

        public TreeNode<T> RemoveChild(int index)
        {
            if (index < 0 || index >= childs.Count)
                throw new ArgumentOutOfRangeException("index");

            TreeNode<T> child = childs[index];
            childs.RemoveAt(index);
            return child;
        }

        #region IEnumerable<TreeNode<T>> Members

        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            return childs.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return childs.GetEnumerator();
        }

        #endregion
    }
}