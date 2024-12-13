
using SAKA20_BLL.Entities;
using SAKA20_BLL.Mapper;
using SAKA20_DB;
using SAKA20_Common.Repositories;

namespace SAKA20_BLL.Services
{
    public class VinService : IVinRepository<Vin, int>
    {
        private DataContext _context;

        public VinService(DataContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            _context.Vin.Remove(_context.Vin.First(a => a.Idvin == id));
            _context.SaveChanges();
        }

        public bool Create(Vin entity)
        {

            _context.Vin.Add(entity.ToEU2());
            _context.SaveChanges();
            return true;

        }

        public IEnumerable<Vin> Get()
        {
            try
            {
                return _context.Vin.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Vin>();
            }
        }

        public Vin Get(int id)
        {
            try
            {
                return _context.Vin.First(l => l.Idvin == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Vin();
            }
        }


        public void Update(int id, Vin entity)
        {
            try
            {
                var Vin = _context.Vin.First(l => l.Idvin == id);
                Vin.Nom = entity.Nom;
                Vin.Fournisseur = entity.Fournisseur;
                Vin.Cuvee = entity.Cuvee;
                Vin.Type = entity.Type;
                Vin.Format = entity.Format;
                Vin.Disponible = entity.Disponible;
                Vin.Stock = entity.Stock;
                Vin.Empalpha = entity.Empalpha;
                Vin.Empnum = entity.Empnum;
                Vin.Prix = entity.Prix;
                Vin.Prixtva = entity.Prixtva;


                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

        public void UpdateDispo(int id, Vin entity)
        {
            try
            {
                var Vin = _context.Vin.First(l => l.Idvin == id);

                Vin.Disponible = entity.Disponible;
                Vin.Stock = entity.Stock;



                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

    }
}
