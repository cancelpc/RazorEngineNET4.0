﻿
using System.Web.Razor.Text;
namespace System.Web.Razor.Parser.SyntaxTree {
    public abstract class SyntaxTreeNode {
        public Block Parent { get; internal set; }

        /// <summary>
        /// Returns true if this element is a block (to avoid casting)
        /// </summary>
        public abstract bool IsBlock { get; }

        /// <summary>
        /// The length of all the content contained in this node
        /// </summary>
        public abstract int Length { get; }
        
        /// <summary>
        /// The start point of this node
        /// </summary>
        public abstract SourceLocation Start { get; }
        
        /// <summary>
        /// Accepts a parser visitor, calling the appropriate visit method and passing in this instance
        /// </summary>
        /// <param name="visitor">The visitor to accept</param>
        public abstract void Accept(ParserVisitor visitor);
    }
}
