namespace RamiloAlonsoSaraTarea3.Models
{
    public class ProfesoresManager : IDisposable
    {
        private readonly ProfesoresContext _context;

        public ProfesoresManager(ProfesoresContext context)
        {
            _context = context;
        }

        public IEnumerable<Profesores> GetAllProfesores()
        {
            var profesores = from Profesores in _context.Profesores
                              select Profesores;
            return profesores;
        }

        public Profesores GetProfesorByID(int id)
        {
            return (Profesores)_context.Profesores.FirstOrDefault(profesor => profesor.Id == id);
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
