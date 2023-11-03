namespace RamiloAlonsoSaraTarea3.Models
{
    public class EstudiantesManager : IDisposable
    {
        private readonly EstudiantesContext _context;

        public EstudiantesManager(EstudiantesContext context)
        {
            _context = context;
        }

        public IEnumerable<Estudiantes> GetAllEstudiantes()
        {
            var estudiantes = from Estudiantes in _context.Estudiantes
                              select Estudiantes;
            return estudiantes;
        }

        public Estudiantes GetEstudianteByID(int id)
        {
            return (Estudiantes)_context.Estudiantes.FirstOrDefault(estudiante => estudiante.Id == id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
