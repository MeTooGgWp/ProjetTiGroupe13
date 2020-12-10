namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class SaveRollManager
    {
        public bool ForceSave { get; set; }
        public bool DexteriteSave { get; set; }
        public bool ConstitutionSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public bool SagesseSave { get; set; }
        public bool CharismeSave { get; set; }


        public SaveRollManager()
        {
            ForceSave = false;
            DexteriteSave = false;
            ConstitutionSave = false;
            IntelligenceSave = false;
            SagesseSave = false;
            CharismeSave = false;
        }
    }
}