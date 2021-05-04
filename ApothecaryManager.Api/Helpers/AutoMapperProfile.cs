using ApothecaryManager.Api.Models;
using ApothecaryManager.Data.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.Api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();

            CreateMap<DrugModel, Drug>();
            CreateMap<InventoryModel, Inventory>();
            CreateMap<PrescriptionModel, Prescription>();
            CreateMap<SaleDetailModel, SaleDetail>();
            CreateMap<SaleModel, Sale>();
            CreateMap<SupplierModel, Supplier>();
        }
    }
}
