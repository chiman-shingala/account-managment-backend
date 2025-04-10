using Acc.Data.Interfaces;
using Acc.Data.Repositories;
using Acc.Data.Repository.Interface;
using Acc.Services.Interfaces;
using Acc.Services.Services;
using Acc.Shared.Common;
using Data.Interfaces;
using Data.Repositories;
using Services.Interfaces;
using Services.Services;

namespace Acc.Api.Extensions
{
	public static class ServiceRegistration
	{
		public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IDRepository, DRepository>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IColMastRepository, ColMastRepository>();
			services.AddScoped<IColMastService, ColMastService>();
			services.AddScoped<ICutMastRepository, CutMastRepository>();
			services.AddScoped<ICutMastService, CutMastService>();
			services.AddScoped<IPurityMastRepository, PurityMastRepository>();
			services.AddScoped<IPurityService, PurityService>();
			services.AddScoped<IShpMastRepository, ShpMastRepository>();
			services.AddScoped<IShpMastService, ShpMastService>();
			services.AddScoped<ISizeMastRepository, SizeMastRepository>();
			services.AddScoped<ISizeMastService, SizeMastService>();
			services.AddScoped<IGrpMastRepository, GrpMastRepository>();
			services.AddScoped<IGrpMastService, GrpMastService>();
			services.AddScoped<IAccYearRepository, AccYearRepository>();
			services.AddScoped<IAccYearService, AccYearService>();
			services.AddScoped<IAGrpMastRepository, AGrpMastRepository>();
			services.AddScoped<IAGrpMastService, AGrpMastService>();
			services.AddScoped<ICurrMastRepository, CurrMastRepository>();
			services.AddScoped<ICurrMastService, CurrMastService>();
			services.AddScoped<ICompMastRepository, CompMastRepository>();
			services.AddScoped<ICompMastService, CompMastService>();
			services.AddScoped<IPktGroupRepository, PktGroupRepository>();
			services.AddScoped<IPktGroupService, PktGroupService>();
			services.AddScoped<IParMastRepository, ParMastRepository>();
			services.AddScoped<IParMastService, ParMastService>();
			services.AddScoped<IPCompMastRepository, PCompMastRepository>();
			services.AddScoped<IPCompMastService, PCompMastService>();
			services.AddScoped<ICertMastRepository, CertMastRepository>();
			services.AddScoped<ICertMastService, CertMastService>();
			services.AddScoped<IPersonMastRepository, PersonMastRepository>();
			services.AddScoped<IPersonMastService, PersonMastService>();
			services.AddScoped<IItemMastRepository, ItemMastRepository>();
			services.AddScoped<IItemMastService, ItemMastService>();
			services.AddScoped<IStonNatRepository, StonNatRepository>();
			services.AddScoped<IStonNatService, StonNatService>();
			services.AddScoped<IDeptMastRepository, DeptMastRepository>();
			services.AddScoped<IDeptMastService, DeptMastService>();
			services.AddScoped<IDesgMastRepository, DesgMastRepository>();
			services.AddScoped<IDesgMastService, DesgMastService>();
			services.AddScoped<IBrokenMastRepository, BrokenMastRepository>();
			services.AddScoped<IBrokenMastService, BrokenMastService>();
			services.AddScoped<IKtMastRepository, KtMastRepository>();
			services.AddScoped<IKtMastService, KtMastService>();
			services.AddScoped<IParPktMastRepository, ParPktMastRepository>();
			services.AddScoped<IParPktMastService, ParPktMastService>();
			services.AddScoped<IPropertyMastRepository, PropertyMastRepository>();
			services.AddScoped<IPropertyMastService, PropertyMastService>();
			services.AddScoped<ITaskMastRepository, TaskMastRepository>();
			services.AddScoped<ITaskMastService, TaskMastService>();
			services.AddScoped<IRemaindMastRepository, RemaindMastRepository>();
			services.AddScoped<IRemaindMastService, RemaindMastService>();
			services.AddScoped<ILustMastRepository,LustMastRepository>();
			services.AddScoped<ILustMastService, LustMastService>();
			services.AddScoped<IPacketEntService, PacketEntService>();
			services.AddScoped<IRapaportRepository, RapaportRepository>();
			services.AddScoped<IBrnMastRepository, BrnMastRepository>();
			services.AddScoped<ICulMastRepository, CulMastRepository>();
			services.AddScoped<IEFacMastRepository, EFacMastRepository>();
			services.AddScoped<IHAMastRepository, HAMastRepository>();
			services.AddScoped<IRSIncMastRepository, RSIncMastRepository>();
			services.AddScoped<ILustMastRepository, LustMastRepository>();
			services.AddScoped<ISBIncMastRepository, SBIncMastRepository>();
			services.AddScoped<ISIncMastRepository, SIncMastRepository>();
			services.AddScoped<ISOIncMastRepository, SOIncMastRepository>();
			services.AddScoped<ITBIncMastRepository, TBIncMastRepository>();
			services.AddScoped<ITIncMastRepository, TIncMastRepository>();
			services.AddScoped<ITOIncMastRepository, TOIncMastRepository>();
			services.AddScoped<ITBIncMastRepository, TBIncMastRepository>();
			services.AddScoped<ITIncMastRepository, TIncMastRepository>();
			services.AddScoped<ITOIncMastRepository, TOIncMastRepository>();

			services.AddScoped<CommonMethods>();
			return services;
		}
	}
}
