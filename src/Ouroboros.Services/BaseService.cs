using AutoMapper;
using Ouroboros.Common.IDCode.Snowflake;
using Ouroboros.DbContexts;
using Ouroboros.UnitOfWork;
using System;

namespace Ouroboros.Services
{
    public interface IBaseService
    {
    }
    public class BaseService : IBaseService
    {
        public readonly IUnitOfWork<MSDbContext> _unitOfWork;
        public readonly IMapper _mapper;
        public readonly IdWorker _idWorker;

        public BaseService(IUnitOfWork<MSDbContext> unitOfWork, IMapper mapper, IdWorker idWorker)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _idWorker = idWorker;
        }
    }

}
