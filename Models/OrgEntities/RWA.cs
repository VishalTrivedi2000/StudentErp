using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMNEVH.Models.OrgEntities
{
    public class RWAForm
    {

    }
    public class RWA
    {
        public string resultString { get; set; }
        public string memberCount { get; set; }
        public string areaOfIntrest { get; set; }
        public string reverPits { get; set; }
        public string reverPitsUnitId { get; set; }
        public string numberOfTanks { get; set; }
        public string tankUnitId { get; set; }
        public string harvesting { get; set; }
        public string numberOfMotor { get; set; }
        public string areaOfRoof { get; set; }
        public string areaOfRoofUnitId { get; set; }
        public string parkDetails { get; set; }
        public string SeverStatus { get; set; }
        public string WaterSupply { get; set; }
        public string drainage { get; set; }
        public string gcDoorToDoorCollection { get; set; }
        public string numberOfTowers { get; set; }
        public string GCCAgency { get; set; }
        public string step { get; set; }
        public string stepReCheck { get; set; }
        public string pk_userTypeId { get; set; }
        public string pk_genderId { get; set; }
        public string rwaId { get; set; }
        public string rwaName { get; set; }
        public string rwaRegNo { get; set; }
        public string fk_countryCode { get; set; }
        public string fk_stateCode { get; set; }
        public string fk_distCode { get; set; }
        public string fk_blockCode { get; set; }
        public string rwaAddress { get; set; }
        public string rwaLandmark1 { get; set; }
        public string rwaLandmark2 { get; set; }
        public string rwaNoOfHouse { get; set; }
        public string president { get; set; }
        public string genSecretary { get; set; }
        public string genSecretaryMobile { get; set; }
        public string presidentMobile { get; set; }
        public string rwaIsActive { get; set; }
        public string registrationIsCompelted { get; set; }
        public string rwaHead { get; set; }
        public string pincode { get; set; }
        public string[] memberPhoneNumber { get; set; }
        public string[] rwaMemberName { get; set; }
        public string[] memberEmailId { get; set; }
        public string[] memberProfile { get; set; }
        public string[] pk_MemberGenderId { get; set; }
        public string[] fk_designationId { get; set; }
        public List<RWAMember> RWAMemberList { get; set; }
    }
    public class RWAMember
    {
        public string rwaMemberName { get; set; }
        public string fk_designationId { get; set; }
        public string memberPhoneNumber { get; set; }
        public string memberEmailId { get; set; }
        public string memberProfile { get; set; }
        public string pk_MemberGenderId { get; set; }
        public string rwaId { get; set; }
        public string step { get; set; }
    }
    public class RWADetails
    {

        public string rwaId { get; set; }
        public string rwaName { get; set; }
        public string rwaRegNo { get; set; }
        public string fk_countryCode { get; set; }
        public string fk_stateCode { get; set; }
        public string fk_distCode { get; set; }
        public string fk_blockCode { get; set; }
        public string rwaAddress { get; set; }
        public string rwaLandmark1 { get; set; }
        public string rwaLandmark2 { get; set; }
        public string rwaNoOfHouse
        { get; set; }
        public string rwaIsActive { get; set; }
        public string step { get; set; }
        public string registrationIsCompelted { get; set; }
        public string rwaHead { get; set; }
        public string president { get; set; }
        public string genSecretary { get; set; }
        public string genSecretaryMobile { get; set; }
        public string presidentMobile { get; set; }
        public string pk_genderId { get; set; }
        public string
pincode
        { get; set; }
        public string fk_blockId { get; set; }
        public string memberCount { get; set; }
        public string numberOfTowers { get; set; }
        public string areaOfIntrest { get; set; }
        public string harvesting { get; set; }
        public string reverPits { get; set; }
        public string reverPitsUnitId { get; set; }
        public string numberOfTanks { get; set; }
        public string tankUnitId { get; set; }
        public string numberOfMotor { get; set; }
        public string areaOfRoof { get; set; }
        public string areaOfRoofUnitId { get; set; }
        public string SeverStatus { get; set; }
        public string WaterSupply { get; set; }
        public string drainage { get; set; }
        public string parkDetails { get; set; }
        public string gcDoorToDoorCollection { get; set; }
        public string GCCAgency { get; set; }
    }

    public class ListClass
    {
        public List<RWADetails> RWADetailsList { get; internal set; }
    }
}