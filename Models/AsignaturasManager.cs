namespace RamiloAlonsoSaraTarea3.Models
{
    public class AsignaturasManager : IDisposable
    {

        private readonly AsignaturasContext _context;

        public AsignaturasManager(AsignaturasContext context)
        {
            _context = context;
        }

        public IEnumerable<Asignaturas> GetAllAsignaturas()
        {
            var asignaturas = from Asignaturas in _context.Asignaturas
                           select Asignaturas;
            return asignaturas;
        }

        public Asignaturas GetAsignaturaByID(int id)
        {
            return (Asignaturas)_context.Asignaturas.FirstOrDefault(asignatura => asignatura.id == id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
