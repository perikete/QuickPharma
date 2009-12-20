using System;

namespace QuickPharma.Core.Model
{
    /// <summary>
    /// Abstract class Drug, used to represent a base implementation for all 
    /// the possible drugs.
    /// </summary>
    public abstract class Drug : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string BarCode { get; private set; }
        public string Presentation { get; private set; }
        public Dosis Dosis{ get; private set; }
        public abstract bool IsRecipeRequired { get; }
        public bool NeedsRefrigeration { get; private set; }
        public Laboratory Laboratory { get; private set; }
               
        public Drug(string name, string description, string barCode, Dosis dosis, string presentation, bool needsRefrigeration,
            Laboratory laboratory)
        {
            this.Name = name;
            this.Description = description;
            this.BarCode = barCode;
            this.Dosis = dosis;
            this.Presentation = presentation;
            this.NeedsRefrigeration = needsRefrigeration;
            this.Laboratory = laboratory;
        }
    }
}
