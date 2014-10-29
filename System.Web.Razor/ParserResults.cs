﻿using System.Collections.Generic;
using System.Web.Razor.Parser.SyntaxTree;

namespace System.Web.Razor {
    /// <summary>
    /// Represents the results of parsing a Razor document
    /// </summary>
    public class ParserResults {
        /// <summary>
        /// Indicates if parsing was successful (no errors)
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// The root node in the document's syntax tree
        /// </summary>
        public Block Document { get; private set; }

        /// <summary>
        /// The list of errors which occurred during parsing.
        /// </summary>
        public IList<RazorError> ParserErrors { get; private set; }

        public ParserResults(Block document, IList<RazorError> parserErrors) : this(parserErrors == null, document, parserErrors) { }

        protected ParserResults(bool success, Block document, IList<RazorError> errors) {
            Success = success;
            Document = document;
            ParserErrors = errors ?? new List<RazorError>();
        }
    }
}
