using _24CV_WEB.Models;
using _24CV_WEB.Repository;
using _24CV_WEB.Repository.CurriculumDAO;
using _24CV_WEB.Services.Contracts;
using Microsoft.IdentityModel.Tokens;

namespace _24CV_WEB.Services.ContractServices
{
    public class CurriculumService : ICurriculumService
    {
        private CurriculumRepository _repository;

        public CurriculumService(ApplicationDbContext context)
        {
            _repository = new CurriculumRepository(context);
        }


        public ResponseHelper Create(Curriculum model)
        {


            ResponseHelper responseHelper = new ResponseHelper();

            try
            {
                if (_repository.Create(model) > 0)
                {
                    responseHelper.Success = true;
                    responseHelper.Message = $"Se agregó el Curriculum de {model.Nombre} con éxito.";
                }
                else
                {
                    responseHelper.Message = "Ocurrio un error al agregar el dato.";
                }
            }
            catch (Exception e)
            {
                responseHelper.Message = $"Ocurrio un error al agregar el dato. Error: {e.Message}";
                throw;
            }

            return responseHelper;

        }

        public ResponseHelper Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Curriculum> GetAll()
        {
            throw new NotImplementedException();
        }

        public Curriculum GetCurriculum(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseHelper Update(Curriculum model)
        {
            throw new NotImplementedException();
        }
    }
}
