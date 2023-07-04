using CameYA.Core.DTOs;
using FluentValidation;

namespace CameYA.Infrastructure.Validators
{
    public class WorkerValidators : AbstractValidator<WorkerDTO>
    {
        public WorkerValidators()
        {
            RuleFor(worker => worker.dni).NotEmpty();
            RuleFor(worker => worker.password).NotEmpty();
            RuleFor(worker => worker.email).NotEmpty();
        }
    }
}
