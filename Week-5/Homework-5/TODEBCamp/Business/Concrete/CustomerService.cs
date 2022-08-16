using System.Collections.Generic;
using AutoMapper;
using Business.Configuration.Validator.FluentValidation;
using Businnes.Abstract;
using Businnes.Configuration.Response;
using Businnes.Configuration.Validator.FluentValidation;
using DAL.Abstract;
using DTO.Customer;
using FluentValidation;
using Models.Entities;


namespace Businnes.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICostumerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICostumerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }


        public CommandResponse Insert(CreateCustomerRequest request)
        {
            // validator
            var validator = new CreateCustomerRequestValidator();
            validator.ValidateAndThrow(request);

 
            var entity = _mapper.Map<Customer>(request);

            _repository.Insert(entity);
            return new CommandResponse
            {
                Status = true,
                Message = $"Customer Added. Id = {entity.Id} Name = {entity.FirstName}"
            };
        }

        public CommandResponse Update(UpdateCustomerRequest request)
        {
            var validator = new UpdateCustomerRequestValidator();
            validator.ValidateAndThrow(request);

            var entity = _repository.Get(request.Id);
            if (entity == null)
            {
                return new CommandResponse
                {
                    Status = false,
                    Message = "The update could not be performed because this id is not registered in the database.."
                };
            }

            var mappedentity = _mapper.Map(request, entity);
            _repository.Update(mappedentity);
            return new CommandResponse
            {
                Status = true,
                Message = $"Customer Updated. "
            };
        }


        public CommandResponse Delete(DeleteCustomerRequest request)
        {
            var validator = new DeleteCustomerRequestValidator();
            validator.ValidateAndThrow(request);

            var entity = _repository.Get(request.Id);
            if (entity == null)
            {
                return new CommandResponse
                {
                    Status = false,
                    Message = "The delete could not be performed because this id is not registered in the database.."
                };
            }


            var mappedentity = _mapper.Map(request, entity);
            _repository.Delete(mappedentity);
            return new CommandResponse
            {
                Status = true,
                Message = $"Customer Deleted."
            };
        }



    }
}
