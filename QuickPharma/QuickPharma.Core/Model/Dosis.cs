namespace QuickPharma.Core.Model
{
    /// <summary>
    /// Dosis Value Object to represent the dosis of a Drug.
    /// </summary>
    public class Dosis : ValueObject
    {
        public int Value { get; private set; }
        public UnitType UnitType { get; private set; }

        /// <summary>
        /// Contructor for the value object dosis.
        /// </summary>
        /// <param name="value">The dosis value.</param>
        /// <param name="unitDescription">The description of the unit used for the value 
        /// field(MG, ML,</param>
        public Dosis(int value, UnitType unitType)
        {
            this.Value = value;
            this.UnitType = unitType;            
        }
    }
}
