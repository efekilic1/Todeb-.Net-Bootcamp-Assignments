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
        // DAL katmanıyla bağlantımızı interface ile sağlıyoruz.
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
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
            // Bu kısımda kullanıcıdan aldığımız değerlerin istenilen biçimde olup olmadığını kontrol ediyoruz.
            var validator = new CreateCustomerRequestValidator();
            validator.ValidateAndThrow(request);

 
            var entity = _mapper.Map<Customer>(request);

            _repository.Add(entity);
            return new CommandResponse
            {
                Status = true,
                Message = $"Customer Added. Id = {entity.Id} Name = {entity.FirstName}"
            };
        }

        public CommandResponse Update(UpdateCustomerRequest request)
        {
            // validator
            var validator = new UpdateCustomerRequestValidator();
            validator.ValidateAndThrow(request);

            var entity = _repository.Get(x => x.Id == request.Id);
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
            // validator
            var validator = new DeleteCustomerRequestValidator();
            validator.ValidateAndThrow(request);

            var entity = _repository.Get(x => x.Id == request.Id);
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
