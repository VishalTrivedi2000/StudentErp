using Microsoft.AspNetCore.Mvc.Rendering;

namespace AMNEVH.Models.Georegion
{
    public class District
    {
        public static List<SelectListItem> DistList { get; set; } = getDistrict();

        private static List<SelectListItem> getDistrict()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query =  Task.Run(() => executer.select<SelectListItem>("VIP_District"));
             query.Result.resultData.Insert(0,new SelectListItem() {Value="0",Text="-Select-" });
            return query.Result.resultData;
        }
    }
    public class UserType
    {
        public static List<SelectListItem> UserTypeList { get; set; } = getUserType();

        private static List<SelectListItem> getUserType()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_getUserType"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    } 
    public class UserDesignation
    {
        public static List<SelectListItem> UserDesignationList { get; set; } = getUserDesignation();

        private static List<SelectListItem> getUserDesignation()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_GetDesignation"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
    public class Gender
    {
        public static List<SelectListItem> GenderList { get; set; } = getGenderList();

        private static List<SelectListItem> getGenderList()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_GetMasterGender"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
    public class Block
    {
        public static List<SelectListItem> BlockList { get; set; } = getBlockList();

        private static List<SelectListItem> getBlockList()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_getBlockList"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
}
namespace AMNEVH.Models.Units
{
    public class AreaUnits
    {
        public static List<SelectListItem> AreaUnitList { get; set; } = getGetAreaUnits();

        private static List<SelectListItem> getGetAreaUnits()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query =  Task.Run(() => executer.select<SelectListItem>("VIP_getGetAreaUnits"));
             query.Result.resultData.Insert(0,new SelectListItem() {Value="0",Text="-Select-" });
            return query.Result.resultData;
        }
    }
    public class VolumeUnits
    {
        public static List<SelectListItem> ValumeUntisList { get; set; } = getVolumeUnits();

        private static List<SelectListItem> getVolumeUnits()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_getVolumeUnits"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    } 
    public class UserDesignation
    {
        public static List<SelectListItem> UserDesignationList { get; set; } = getUserDesignation();

        private static List<SelectListItem> getUserDesignation()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_GetDesignation"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
    public class Gender
    {
        public static List<SelectListItem> GenderList { get; set; } = getGenderList();

        private static List<SelectListItem> getGenderList()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_GetMasterGender"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
    public class Block
    {
        public static List<SelectListItem> BlockList { get; set; } = getBlockList();

        private static List<SelectListItem> getBlockList()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_getBlockList"));
            query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
    public class YesNo
    {
        public static List<SelectListItem> YesNoList { get; set; } = getYesNo();

        private static List<SelectListItem> getYesNo()
        {
            Executer executer = new Executer();
            Task<Query<SelectListItem>> query = Task.Run(() => executer.select<SelectListItem>("VIP_YesNo"));
          //  query.Result.resultData.Insert(0, new SelectListItem() { Value = "0", Text = "-Select-" });
            return query.Result.resultData;
        }
    }
}