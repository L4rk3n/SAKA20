
using SAKA20_BLL.Entities;
using SAKA20_BLL.Mapper;
using SAKA20_DB;
using SAKA20_Common.Repositories;
using static SAKA20_BLL.Services.UtilisateurService;


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
         
                _context.Utilisateur.Add(entity.ToEU());
                _context.SaveChanges();
                return true;
           
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
                Utilisateur.Nom = entity.Nom;
                Utilisateur.Prenom = entity.Prenom;
                Utilisateur.Email = entity.Email;
                Utilisateur.PhoneNumber = entity.PhoneNumber;
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

        public void UpdateAccess(int id, Utilisateur entity)
        {
            try
            {
                var Utilisateur = _context.Utilisateur.First(l => l.IDutilisateur == id);
                Utilisateur.Admin = entity.Admin;
                Utilisateur.Activated = entity.Activated;
                Utilisateur.Cancelled = entity.Cancelled;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Data error !");
            }
        }

        public async Task<bool> UpdatePasswordAsync(int userId, string oldPassword, string newPassword)
            {
                var user = await _context.Utilisateur.FindAsync(userId);
                if (user == null || user.Password != oldPassword)
                {
                    return false;
                }

                user.Password = newPassword;
                _context.Utilisateur.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }


    }
}
