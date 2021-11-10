using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppCatalogService.Core.Application.Interfaces;
using AppCatalogService.Core.Domain.Entities;
using MediatR;


namespace AppCatalogService.Core.Application.Services.Example
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationEntityRepository _applicationEntityRepository;
        public CreateCommandHandler(IUnitOfWork unitOfWork, IApplicationEntityRepository applicationEntityRepository)
        {
            _unitOfWork = unitOfWork;
            _applicationEntityRepository = applicationEntityRepository;
        }
        public async Task<Unit> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
            var test = new Domain.Entities.ApplicationEntity();

            //ToDo:
            //Possibility 1
            //Note as it stands no BaseRepository Add methods includes SaveChanges;
            await _unitOfWork.ApplicationEntityRepository.AddAsync(test, cancellationToken);
            await _unitOfWork.Complete(cancellationToken);

            //Possibility 2
            await _applicationEntityRepository.AddAsync(test, cancellationToken);

            return Unit.Value;
        }
    }
}
