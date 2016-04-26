﻿using Flat.Decoders;

namespace Flat
{
    public static class Decode
    {
        public static TreeWithDependencies<T> HierarchicalGraph<T>(string text, 
            Delegates.CreateNodeFromName<T> createNodeWithName,
            Delegates.AddChildrenToNode<T> addChildrenToNode) 
                =>  HierarchicalGraphDecoder.Decode(text, createNodeWithName, addChildrenToNode);
    }
}
