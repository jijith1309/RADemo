namespace RADemoAPI.Dtos
{
    public class ScanInsuranceResponseDto
    {
        public string CroppedFrontImage { get; set; }
        public string CroppedBackImage { get; set; }

        public InsuranceScanResponse InsuranceScanResponse { get; set; }


    }
    public class InsuranceScanResponse
    {
        public Person Person { get; set; }
        public Insurance Insurance { get; set; }

        public string IssuerNumber { get; set; }
        public string Other { get; set; }
        public string RawText { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public int IsProcessSucessful { get; set; }
        public string TransactionTimestamp { get; set; }
    }
    public class Person
    {
        public string MemberName { get; set; }
        public string NamePrefix { get; set; }
        public string NameSuffix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string LastName { get; set; }
        public string Employer { get; set; }
        public string MemberId { get; set; }
        public Address[] ListAddress { get; set; }
        public Insurance[] ListInsuran { get; set; }
        public LabelValue[] ListWeb { get; set; }
        public LabelValue[] ListEmail { get; set; }
        public LabelValue[] ListPhone { get; set; }
    }
    public class Insurance
    {
        public string GroupNumber { get; set; }
        public string ContractCode { get; set; }
        public string CopayEr { get; set; }
        public string CopayOv { get; set; }
        public string CopaySp { get; set; }
        public string CopayUc { get; set; }
        public string Coverage { get; set; }
        public string Deductible { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Other { get; set; }
        public string PayerId { get; set; }
        public string PlanAdmin { get; set; }
        public string PlanProvider { get; set; }
        public string PlanType { get; set; }
        public string RxBin { get; set; }
        public string RxGroup { get; set; }
        public string RxId { get; set; }
        public string RxPcn { get; set; }
        public LabelValue[] ListDeductible { get; set; }
        public PlanCodeModel[] ListPlanCode { get; set; }
    }
    public class Address
    {
        public string FullAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
    public class LabelValue
    {
        public string Label { get; set; }
        public string Value { get; set; }

    }
    public class PlanCodeModel
    {
        public string PlanCode { get; set; }
    }
}
