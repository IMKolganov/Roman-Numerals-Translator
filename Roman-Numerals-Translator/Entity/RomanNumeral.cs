using System;
using System.Diagnostics;

namespace Roman_Numerals_Translator.Entity
{
    /// <summary>
    /// Represents a Roman numeral with its corresponding value.
    /// </summary>
    public class RomanNumeral
    {
        /// <summary>
        /// Gets or sets the value of the Roman numeral.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the symbol representation of the Roman numeral.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Initializes a new instance of the Romans class.
        /// </summary>
        public RomanNumeral() { }

        /// <summary>
        /// Initializes a new instance of the Romans class with the specified value and symbol.
        /// </summary>
        /// <param name="value">The value of the Roman numeral.</param>
        /// <param name="symbol">The symbol representation of the Roman numeral.</param>
        public RomanNumeral(int value, string symbol)
        {
            Value = value;
            Symbol = symbol;
        }
    }

}

