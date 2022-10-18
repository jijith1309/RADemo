namespace RADemoAPI.Dtos
{
    public class ScanInsuranceRequestDto
    {
        public string EncounterCode { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public bool ReturnFrontImage { get; set; }
        public bool ReturnBackImage { get; set; }
        public bool ReturnDetailedResults { get; set; }
    }
}
