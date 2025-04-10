using Acc.Data.Interfaces;
using Acc.Data.Interfaces.IMaster;
using Acc.Data.Interfaces.IRapaport;
using Acc.Data.Repositories;
using Acc.Data.Repositories.Master;
using Acc.Data.Repositories.Rapaport;
using Acc.Data.Repository.Interface;
using Acc.Services.Interfaces;
using Acc.Services.Interfaces.Master;
using Acc.Services.Interfaces.Rapaport;
using Acc.Services.Services;
using Acc.Services.Services.Master;
using Acc.Services.Services.Rapaport;
using Acc.Shared.Common;
using Services.Interfaces;

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
			services.AddScoped<IRapaportRepository,RapaportRepository>();
			services.AddScoped<IRapaportService, RapaportService>();
			services.AddScoped<CommonMethods>();
			services.AddScoped<IRapDiscRepository, RapDiscRepository>();
			services.AddScoped<IRapDiscService, RapDiscService>();
			services.AddScoped<ICutDiscRepository, CutDiscRepository>();
			services.AddScoped<ICutDiscService, CutDiscService>();
			services.AddScoped<IFluoDiscRepository, FluoDiscRepository>();
			services.AddScoped<IFluoDiscService, FluoDiscService>();
			return services;
		}
	}
}
