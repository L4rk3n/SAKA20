
using SAKA20_BLL.Entities;

using SAKA20_BLL.Mapper;
using SAKA20_DB;
using SAKA20_Common.Repositories;


namespace SAKA20_BLL.Services
{
    public class UtilisateurService : IUtilisateurRepository<Utilisateur,int,string>
    {
        private DataContext _context;

        public UtilisateurService(DataContext context)
        {
            _context = context;
        }

        public bool Create(Utilisateur entity)
        {
            try
            {
                _context.Utilisateur.Add(entity.ToEU());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            _context.Utilisateur.Remove(_context.Utilisateur.First(a => a.IDutilisateur == id));
            _context.SaveChanges();
        }

        public IEnumerable<Utilisateur> Get()
        {
            try
            {
                return _context.Utilisateur.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Utilisateur>();
            }
        }

        public Utilisateur Get(int id)
        {
            try
            {
                return _context.Utilisateur.First(l => l.IDutilisateur == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Utilisateur();
            }
        }

        public Utilisateur Get(string email)
        {
            try
            {
                return _context.Utilisateur.First(l => l.Email == email).ToBLL();
            }
            catch (Exception ex)
            {
                return new Utilisateur();
            }
        }

        public void Update(int id, Utilisateur entity)
        {
            try
            {
                var Utilisateur = _context.Utilisateur.First(l => l.IDutilisateur == id);
                Utilisateur.IDutilisateur = entity.IDutilisateur;
                Utilisateur.Nom = entity.Nom;
                Utilisateur.Prenom = entity.Prenom;
                Utilisateur.Email = entity.Email;
                Utilisateur.PhoneNumber = entity.PhoneNumber;
                Utilisateur.Admin = entity.Admin;
                Utilisateur.Activated = entity.Activated;
                Utilisateur.Cancelled = entity.Cancelled;
                Utilisateur.AdresseRue = entity.AdresseRue;
                Utilisateur.AdresseNumero = entity.AdresseNumero;
                Utilisateur.AdresseCodePostal = entity.AdresseCodePostal;
                Utilisateur.AdresseVille = entity.AdresseVille;
                Utilisateur.AdresseNumeroBoite = entity.AdresseNumeroBoite;
                Utilisateur.AdresseCountry = entity.AdresseCountry;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

    }
}
