using _24CV_WEB.Models;

namespace _24CV_WEB.Services.Contracts
{
    public interface ICurriculumService
    {

        List<Curriculum> GetAll();
        Curriculum GetCurriculum(int id);
        ResponseHelper Create(Curriculum model);
        ResponseHelper Update(Curriculum model);
        ResponseHelper Delete(int id);
    }
}
