namespace OpenIso8583Net.FieldValidator
{
    /// <summary>
    ///   Alpha numeric and space field formatter
    /// </summary>
    public class AlphaNumericAndSpaceFieldValidator : IFieldValidator
    {
        #region IFieldValidator Members

        /// <summary>
        ///   Description of the validator
        /// </summary>
        public string Description
        {
            get { return "ansp"; }
        }

        /// <summary>
        ///   Validates the format of the given string value
        /// </summary>
        /// <param name = "value">Value to validate</param>
        /// <returns>true if valid, false otherwise</returns>
        public bool IsValid(string value)
        {
            foreach (int b in value)
            {
                if (b < 32 || b > 32 && b < 48 || b > 57 && b < 65 || b > 90 && b < 97 || b > 122)
                    return false;
            }
            return true;
        }

        #endregion
    }
}