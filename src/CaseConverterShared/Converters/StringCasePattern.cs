﻿namespace CaseConverter.Converters
{
    /// <summary>
    /// 複合の単語をひと綴りで表す場合のパターンを表します。
    /// </summary>
    public enum StringCasePattern
    {
        /// <summary>
        /// キャメルケースです。
        /// </summary>
        CamelCase,

        /// <summary>
        /// パスカルケースです。
        /// </summary>
        PascalCase,

        /// <summary>
        /// スネークケースです。
        /// </summary>
        SnakeCase,

        /// <summary>
        /// パスカルスネークケースです。
        /// </summary>
        PascalSnakeCase,

        /// <summary>
        /// スクリーミングスネークケースです。
        /// </summary>
        ScreamingSnakeCase,

        /// <summary>
        /// ケバブケースです。
        /// </summary>
        KebabCase,
        /// <summary>
        /// First world starts with capital, all other in lower case
        /// </summary>
        SentenceCase
    }
}
