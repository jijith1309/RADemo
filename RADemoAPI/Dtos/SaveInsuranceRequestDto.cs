namespace RADemoAPI.Dtos
{
    public class SaveInsuranceRequestDto
    {
        public string EncounterCode { get; set; }
        public Insurance InsuranceDetail { get; set; }
        public string InsuranceCardFront { get; set; }
        public string InsuranceCardBack { get; set; }

    }
}
